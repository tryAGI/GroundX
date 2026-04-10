#nullable enable

namespace GroundX
{
    public partial interface ICustomerClient
    {
        /// <summary>
        /// get<br/>
        /// Get the account information associated with the API key.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GroundX.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GroundX.CustomerResponse> CustomerGetAsync(
            global::GroundX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}