# Microsoft.Extensions.AI Integration

GroundX provides `AIFunction` tools that can be used with any `Microsoft.Extensions.AI.IChatClient` to give AI agents access to RAG search, document ingestion, and bucket management capabilities.

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
