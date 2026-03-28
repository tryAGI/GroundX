#nullable enable

namespace GroundX
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// create<br/>
        /// create a new group, a group being a collection of buckets which can be searched.<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GroundX.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GroundX.GroupResponse> GroupCreateAsync(

            global::GroundX.GroupCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// create<br/>
        /// create a new group, a group being a collection of buckets which can be searched.<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="name">
        /// The name of the group being created.<br/>
        /// Example: your_group_name
        /// </param>
        /// <param name="bucketName">
        /// Specify bucketName to automatically create a bucket, by the name specified, and add it to the created group.<br/>
        /// Example: your_new_bucket_name
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GroundX.GroupResponse> GroupCreateAsync(
            string name,
            string? bucketName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}