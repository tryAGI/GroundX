#nullable enable

namespace GroundX
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// get<br/>
        /// look up a specific group by its groupId.<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GroundX.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GroundX.GroupResponse> GroupGetAsync(
            int groupId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}