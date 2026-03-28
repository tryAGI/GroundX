#nullable enable

namespace GroundX
{
    public partial interface ICustomerClient
    {
        /// <summary>
        /// get<br/>
        /// Get the account information associated with the API key.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GroundX.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GroundX.CustomerResponse> CustomerGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}