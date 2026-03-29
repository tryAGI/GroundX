# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The GroundX SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to GroundX's RAG search, document ingestion, and bucket management capabilities.

## Available Tools

### AsSearchTool

Searches ingested documents in a GroundX bucket for relevant content.

```csharp
using GroundX;
using Microsoft.Extensions.AI;

var client = new GroundXClient(apiKey);
var tool = client.AsSearchTool(n: 10);

// Use with any IChatClient
var options = new ChatOptions
{
    Tools = [tool],
};
```

### AsIngestUrlTool

Ingests a document from a public URL into a GroundX bucket.

```csharp
var tool = client.AsIngestUrlTool();
```

### AsGetIngestStatusTool

Checks the processing status of a document ingestion job.

```csharp
var tool = client.AsGetIngestStatusTool();
```

### AsListBucketsTool

Lists all available content buckets in your GroundX account.

```csharp
var tool = client.AsListBucketsTool();
```

## Using All Tools Together

```csharp
using GroundX;
using Microsoft.Extensions.AI;

var groundx = new GroundXClient(apiKey);

var options = new ChatOptions
{
    Tools =
    [
        groundx.AsSearchTool(),
        groundx.AsIngestUrlTool(),
        groundx.AsGetIngestStatusTool(),
        groundx.AsListBucketsTool(),
    ],
};

// Pass to any IChatClient (OpenAI, Anthropic, Ollama, etc.)
var response = await chatClient.GetResponseAsync(
    "Search for information about RAG in bucket 1234",
    options);
```
