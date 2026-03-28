namespace GroundX.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static GroundXClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("GROUNDX_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("GROUNDX_API_KEY environment variable is not found.");

        var client = new GroundXClient(apiKey);
        
        return client;
    }
}
