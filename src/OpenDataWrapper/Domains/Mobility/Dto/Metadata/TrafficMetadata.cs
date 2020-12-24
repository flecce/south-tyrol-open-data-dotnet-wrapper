using System.Text.Json.Serialization;

namespace OpenDataWrapper.Domains.Mobility.Dto.Metadata
{
    /// <summary>
    /// Traffic metadata.
    /// </summary>
    public class TrafficMetadata
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
