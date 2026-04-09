
#nullable enable

namespace GroundX
{
    public sealed partial class GroundXClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "X-API-Key")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::GroundX.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "X-API-Key",
                Value = apiKey,
            });
        }
    }
}