
#nullable enable

namespace GroundX
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcessStatusResponseIngest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProcessId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public global::GroundX.ProcessStatusResponseIngestProgress? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GroundX.JsonConverters.ProcessingStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GroundX.ProcessingStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusMessage")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessStatusResponseIngest" /> class.
        /// </summary>
        /// <param name="processId"></param>
        /// <param name="status"></param>
        /// <param name="progress"></param>
        /// <param name="statusMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcessStatusResponseIngest(
            global::System.Guid processId,
            global::GroundX.ProcessingStatus status,
            global::GroundX.ProcessStatusResponseIngestProgress? progress,
            string? statusMessage)
        {
            this.ProcessId = processId;
            this.Progress = progress;
            this.Status = status;
            this.StatusMessage = statusMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessStatusResponseIngest" /> class.
        /// </summary>
        public ProcessStatusResponseIngest()
        {
        }
    }
}