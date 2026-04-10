#nullable enable

namespace GroundX
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// get<br/>
        /// Look up the current health status of a specific service. Statuses update every 5 minutes.
        /// </summary>
        /// <param name="service"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GroundX.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GroundX.HealthResponse> HealthGetAsync(
            string service,
            global::GroundX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}