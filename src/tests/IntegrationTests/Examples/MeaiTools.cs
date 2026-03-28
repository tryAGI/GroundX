/* order: 30, title: MEAI Tools, slug: meai-tools */

using Microsoft.Extensions.AI;

namespace GroundX.IntegrationTests;

public partial class Tests
{
    //// GroundX provides AIFunction tools that can be used with any
    //// `Microsoft.Extensions.AI.IChatClient` to give AI agents access to
    //// RAG search, document ingestion, and bucket management capabilities.

    [TestMethod]
    public async Task Meai_AsSearchTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that searches ingested documents:
        var tool = client.AsSearchTool();

        tool.Name.Should().Be("GroundXSearch");
        tool.Description.Should().Contain("search");
    }

    [TestMethod]
    public async Task Meai_AsIngestUrlTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that ingests documents from URLs:
        var tool = client.AsIngestUrlTool();

        tool.Name.Should().Be("GroundXIngestUrl");
        tool.Description.Should().Contain("ingest");
    }

    [TestMethod]
    public async Task Meai_AsGetIngestStatusTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that checks ingestion status:
        var tool = client.AsGetIngestStatusTool();

        tool.Name.Should().Be("GroundXGetIngestStatus");
        tool.Description.Should().Contain("status");
    }

    [TestMethod]
    public async Task Meai_AsListBucketsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that lists available buckets:
        var tool = client.AsListBucketsTool();

        tool.Name.Should().Be("GroundXListBuckets");
        tool.Description.Should().Contain("bucket");
    }
}
