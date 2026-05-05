#nullable enable

namespace GroundX
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// get_processing_status_by_id<br/>
        /// Get the current status of an ingest, initiated with documents.ingest_remote, documents.ingest_local, or documents.crawl_website, by specifying the processId (the processId is included in the response of the documents.ingest functions).<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="processId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GroundX.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GroundX.ProcessStatusResponse> DocumentGetProcessingStatusByIdAsync(
            global::System.Guid processId,
            global::GroundX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// get_processing_status_by_id<br/>
        /// Get the current status of an ingest, initiated with documents.ingest_remote, documents.ingest_local, or documents.crawl_website, by specifying the processId (the processId is included in the response of the documents.ingest functions).<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="processId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GroundX.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GroundX.AutoSDKHttpResponse<global::GroundX.ProcessStatusResponse>> DocumentGetProcessingStatusByIdAsResponseAsync(
            global::System.Guid processId,
            global::GroundX.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}