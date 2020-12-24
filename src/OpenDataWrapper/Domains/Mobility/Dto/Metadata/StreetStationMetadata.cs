using System.Text.Json.Serialization;

namespace OpenDataWrapper.Domains.Mobility.Dto.Metadata
{
    /// <summary>
    /// Street station metadata.
    /// </summary>
    public class StreetStationMetadata
    {
        [JsonPropertyName("length")]
        public int Length { get; set; }

        [JsonPropertyName("old_idstr")]
        public int OldStreetId { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("speed_default")]
        public int SpeedDefault { get; set; }

        [JsonPropertyName("linegeometry")]
        public string LineGeometry { get; set; }
    }
}
