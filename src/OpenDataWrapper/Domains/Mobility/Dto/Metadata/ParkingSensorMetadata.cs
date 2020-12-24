using System.Text.Json.Serialization;

namespace OpenDataWrapper.Domains.Mobility.Dto.Metadata
{
    /// <summary>
    /// Parking sensor metadata.
    /// </summary>
    public class ParkingSensorMetadata
    {
        [JsonPropertyName("id2")]
        public string Id2 { get; set; }

        [JsonPropertyName("group")]
        public string Group { get; set; }

        [JsonPropertyName("municipality")]
        public string Municipality { get; set; }
    }
}
