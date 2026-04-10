#nullable enable

namespace GroundX
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// crawl_website<br/>
        /// Upload the content of a publicly accessible website for ingestion into a GroundX bucket. This is done by following links within a specified URL, recursively, up to a specified depth or number of pages.<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GroundX.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GroundX.IngestResponse> DocumentCrawlWebsiteAsync(

            global::GroundX.WebsiteCrawlRequest request,
            global::GroundX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// crawl_website<br/>
        /// Upload the content of a publicly accessible website for ingestion into a GroundX bucket. This is done by following links within a specified URL, recursively, up to a specified depth or number of pages.<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="websites"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GroundX.IngestResponse> DocumentCrawlWebsiteAsync(
            global::System.Collections.Generic.IList<global::GroundX.WebsiteCrawlRequestWebsite> websites,
            global::GroundX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}