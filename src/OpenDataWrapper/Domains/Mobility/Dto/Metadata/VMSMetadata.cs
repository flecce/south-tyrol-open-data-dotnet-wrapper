using System.Text.Json.Serialization;

namespace OpenDataWrapper.Domains.Mobility.Dto.Metadata
{
    /// <summary>
    /// VMS metadata.
    /// </summary>
    public class VMSMetadata
    {
        [JsonPropertyName("pmv_type")]
        public string PMVType { get; set; }

        [JsonPropertyName("position_m")]
        public string PositionM { get; set; }

        [JsonPropertyName("segment_end")]
        public string EndSegment { get; set; }

        [JsonPropertyName("direction_id")]
        public string DirectionId { get; set; }

        [JsonPropertyName("segment_start")]
        public string StartSegment { get; set; }
    }
}
