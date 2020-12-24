using System.Text.Json.Serialization;

namespace OpenDataWrapper.Domains.Mobility.Dto.Metadata
{
    /// <summary>
    /// Link station metadata.
    /// </summary>
    public class LinkStationMetadata
    {
        [JsonPropertyName("lunghezza")]
        public int Lenght { get; set; }

        [JsonPropertyName("metrofine")]
        public int StartMt { get; set; }

        [JsonPropertyName("iddirezione")]
        public string DirectionId { get; set; }

        [JsonPropertyName("metroinizio")]
        public int EndMt { get; set; }

        [JsonPropertyName("latitudinefine")]
        public double EndLat { get; set; }

        [JsonPropertyName("longitudinefine")]
        public double EndLon { get; set; }

        [JsonPropertyName("latitudineinizio")]
        public double StartLat { get; set; }

        [JsonPropertyName("longitudininizio")]
        public double StartLon { get; set; }
    }
}
