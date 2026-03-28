/* order: 10, title: Getting Started, slug: getting-started */

namespace GroundX.IntegrationTests;

public partial class Tests
{
    //// Create a GroundX client and verify it can connect to the API
    //// by listing available content buckets.

    [TestMethod]
    public async Task Example_ListBuckets()
    {
        using var client = GetAuthenticatedClient();

        //// List all content buckets in your account:
        var response = await client.Buckets.BucketListAsync();

        response.Should().NotBeNull();
    }
}
