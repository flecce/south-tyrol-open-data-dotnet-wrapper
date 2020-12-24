using System.Text.Json.Serialization;

namespace OpenDataWrapper.Domains.Mobility.Dto.Metadata
{
    /// <summary>
    /// Traffic street metadata.
    /// </summary>
    public class TrafficStreetFactorMetadata
    {
        [JsonPropertyName("factor")]
        public int Factor { get; set; }

        [JsonPropertyName("length")]
        public int length { get; set; }

        [JsonPropertyName("hv_perc")]
        public int HVPerc { get; set; }
    }
}
