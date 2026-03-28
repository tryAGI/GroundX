using Microsoft.Extensions.AI;

namespace GroundX;

/// <summary>
/// Extensions for using GroundXClient as MEAI tools with any IChatClient.
/// </summary>
public static class GroundXToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that searches ingested documents in a GroundX bucket,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The GroundX client to use for searches.</param>
    /// <param name="n">Maximum number of search results to return (default: 10).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsSearchTool(
        this GroundXClient client,
        int n = 10)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string query, int bucketId, CancellationToken cancellationToken) =>
            {
                var response = await client.Search.SearchContentAsync(
                    id: bucketId,
                    query: query,
                    n: n,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatSearchResponse(response);
            },
            name: "GroundXSearch",
            description: "Searches ingested documents in a GroundX bucket using a natural language query. Returns relevant text chunks with source information for RAG (retrieval-augmented generation).");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that ingests a document from a URL into a GroundX bucket,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The GroundX client to use for ingestion.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsIngestUrlTool(
        this GroundXClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string sourceUrl, int bucketId, CancellationToken cancellationToken) =>
            {
                var response = await client.Documents.DocumentIngestRemoteAsync(
                    documents: [
                        new DocumentRemoteIngestRequestDocument
                        {
                            BucketId = bucketId,
                            SourceUrl = sourceUrl,
                        },
                    ],
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return $"Ingestion started. Process ID: {response.Ingest.ProcessId}, Status: {response.Ingest.Status}";
            },
            name: "GroundXIngestUrl",
            description: "Ingests a document from a public URL into a GroundX bucket for later search and retrieval. Returns a process ID to track ingestion status.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that checks the status of an ingestion process,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The GroundX client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGetIngestStatusTool(
        this GroundXClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string processId, CancellationToken cancellationToken) =>
            {
                var guid = Guid.Parse(processId);
                var response = await client.Documents.DocumentGetProcessingStatusByIdAsync(
                    processId: guid,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var status = response.Ingest;
                var result = $"Process ID: {status.ProcessId}, Status: {status.Status}";
                if (status.StatusMessage is { Length: > 0 } message)
                {
                    result += $", Message: {message}";
                }

                return result;
            },
            name: "GroundXGetIngestStatus",
            description: "Checks the processing status of a document ingestion job by its process ID. Returns the current status (e.g., queued, processing, complete, error).");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists available buckets,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The GroundX client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListBucketsTool(
        this GroundXClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Buckets.BucketListAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatBucketListResponse(response);
            },
            name: "GroundXListBuckets",
            description: "Lists all available GroundX content buckets. Returns bucket IDs, names, file counts, and sizes.");
    }

    private static string FormatSearchResponse(SearchResponse response)
    {
        var parts = new List<string>();

        if (response.Search.Text is { Length: > 0 } text)
        {
            parts.Add("Context for LLM:");
            parts.Add(text);
            parts.Add("");
        }

        if (response.Search.Results is { Count: > 0 })
        {
            parts.Add("Search Results:");
            foreach (var result in response.Search.Results)
            {
                var entry = $"- [Score: {result.Score:F2}]";
                if (result.FileName is { Length: > 0 } fileName)
                {
                    entry += $" {fileName}";
                }

                if (result.SourceUrl is { Length: > 0 } sourceUrl)
                {
                    entry += $" ({sourceUrl})";
                }

                if (result.SuggestedText is { Length: > 0 } suggestedText)
                {
                    entry += $": {suggestedText}";
                }
                else if (result.Text is { Length: > 0 } resultText)
                {
                    entry += $": {resultText}";
                }

                parts.Add(entry);
            }
        }

        if (parts.Count == 0)
        {
            parts.Add("No results found.");
        }

        return string.Join("\n", parts);
    }

    private static string FormatBucketListResponse(BucketListResponse response)
    {
        var parts = new List<string>();

        if (response.Buckets is { Count: > 0 })
        {
            parts.Add("Buckets:");
            foreach (var bucket in response.Buckets)
            {
                var entry = $"- ID: {bucket.BucketId}";
                if (bucket.Name is { Length: > 0 } name)
                {
                    entry += $", Name: {name}";
                }

                if (bucket.FileCount is { } fileCount)
                {
                    entry += $", Files: {fileCount}";
                }

                if (bucket.FileSize is { Length: > 0 } fileSize)
                {
                    entry += $", Size: {fileSize}";
                }

                parts.Add(entry);
            }
        }
        else
        {
            parts.Add("No buckets found.");
        }

        return string.Join("\n", parts);
    }
}
