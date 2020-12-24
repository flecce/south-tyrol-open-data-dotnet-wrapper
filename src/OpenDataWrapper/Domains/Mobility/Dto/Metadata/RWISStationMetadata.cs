using System.Text.Json.Serialization;

namespace OpenDataWrapper.Domains.Mobility.Dto.Metadata
{
    /// <summary>
    /// RWIS station metadata.
    /// </summary>
    public class RWISStationMetadata
    {
        [JsonPropertyName("metro")]
        public int Metro { get; set; }

        [JsonPropertyName("iddirezione")]
        public string DirectionId { get; set; }
    }
}
