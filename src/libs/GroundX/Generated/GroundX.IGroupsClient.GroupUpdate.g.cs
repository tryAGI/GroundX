#nullable enable

namespace GroundX
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// update<br/>
        /// Rename a group<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GroundX.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GroundX.GroupResponse> GroupUpdateAsync(
            int groupId,

            global::GroundX.GroupUpdateRequest request,
            global::GroundX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// update<br/>
        /// Rename a group<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GroundX.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GroundX.AutoSDKHttpResponse<global::GroundX.GroupResponse>> GroupUpdateAsResponseAsync(
            int groupId,

            global::GroundX.GroupUpdateRequest request,
            global::GroundX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// update<br/>
        /// Rename a group<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="newName">
        /// The new name of the group being renamed.<br/>
        /// Example: your_group_name
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GroundX.GroupResponse> GroupUpdateAsync(
            int groupId,
            string newName,
            global::GroundX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}