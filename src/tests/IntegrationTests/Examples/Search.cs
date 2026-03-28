/* order: 20, title: Search, slug: search */

namespace GroundX.IntegrationTests;

public partial class Tests
{
    //// Search ingested documents in a GroundX bucket for relevant content.
    //// The search API returns both a combined text suitable for LLM context
    //// and individual result chunks for citation.

    [TestMethod]
    public async Task Example_SearchContent()
    {
        using var client = GetAuthenticatedClient();

        var bucketId =
            Environment.GetEnvironmentVariable("GROUNDX_BUCKET_ID") is { Length: > 0 } bucketIdValue
                ? int.Parse(bucketIdValue)
                : throw new AssertInconclusiveException("GROUNDX_BUCKET_ID environment variable is not found.");

        //// Search for relevant content in a bucket:
        var response = await client.Search.SearchContentAsync(
            id: bucketId,
            query: "What is RAG?",
            n: 5);

        response.Should().NotBeNull();
        response.Search.Should().NotBeNull();
    }
}
