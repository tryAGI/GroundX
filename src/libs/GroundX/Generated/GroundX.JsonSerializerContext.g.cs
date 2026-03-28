
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace GroundX
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::GroundX.JsonConverters.DocumentTypeJsonConverter),

            typeof(global::GroundX.JsonConverters.DocumentTypeNullableJsonConverter),

            typeof(global::GroundX.JsonConverters.ProcessingStatusJsonConverter),

            typeof(global::GroundX.JsonConverters.ProcessingStatusNullableJsonConverter),

            typeof(global::GroundX.JsonConverters.SortJsonConverter),

            typeof(global::GroundX.JsonConverters.SortNullableJsonConverter),

            typeof(global::GroundX.JsonConverters.SortOrderJsonConverter),

            typeof(global::GroundX.JsonConverters.SortOrderNullableJsonConverter),

            typeof(global::GroundX.JsonConverters.HealthServiceStatusJsonConverter),

            typeof(global::GroundX.JsonConverters.HealthServiceStatusNullableJsonConverter),

            typeof(global::GroundX.JsonConverters.OneOfJsonConverter<int?, global::System.Guid?>),

            typeof(global::GroundX.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.SearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.SearchDocumentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.SearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.SearchResponseSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::GroundX.SearchResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.SearchResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::GroundX.BoundingBoxDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.BoundingBoxDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.GroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.GroupDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::GroundX.BucketDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.BucketDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.BucketUpdateDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.BucketResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.BucketUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.BucketCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.BucketUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.GroupCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.GroupUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.DocumentDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.DocumentType), TypeInfoPropertyName = "DocumentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.ProcessingStatus), TypeInfoPropertyName = "ProcessingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.DocumentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.DocumentRemoteIngestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::GroundX.DocumentRemoteIngestRequestDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.DocumentRemoteIngestRequestDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::GroundX.DocumentLocalIngestRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.DocumentLocalIngestRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.DocumentLocalIngestRequestItemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.IngestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.IngestResponseIngest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.ProcessStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.ProcessStatusResponseIngest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.ProcessStatusResponseIngestProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.ProcessStatusResponseIngestProgressCancelled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::GroundX.DocumentDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.ProcessStatusResponseIngestProgressComplete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.ProcessStatusResponseIngestProgressErrors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.ProcessStatusResponseIngestProgressProcessing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.GroupListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::GroundX.GroupDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.BucketListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.DocumentListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.DocumentLookupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.WebsiteCrawlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::GroundX.WebsiteCrawlRequestWebsite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.WebsiteCrawlRequestWebsite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.Sort), TypeInfoPropertyName = "Sort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.SortOrder), TypeInfoPropertyName = "SortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.MessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.MeterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.SubscriptionDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.SubscriptionDetailMeters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.CustomerDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.CustomerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.HealthService))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.HealthServiceStatus), TypeInfoPropertyName = "HealthServiceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.HealthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.HealthResponseHealth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::GroundX.HealthService>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::GroundX.OneOf<int?, global::System.Guid?>), TypeInfoPropertyName = "OneOfInt32Guid2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::GroundX.SearchResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::GroundX.BoundingBoxDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::GroundX.BucketDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::GroundX.DocumentRemoteIngestRequestDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::GroundX.DocumentLocalIngestRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::GroundX.DocumentDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::GroundX.GroupDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::GroundX.WebsiteCrawlRequestWebsite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::GroundX.HealthService>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}