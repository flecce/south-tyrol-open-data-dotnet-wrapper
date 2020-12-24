using System.Text.Json.Serialization;

namespace OpenDataWrapper.Domains.Mobility.Dto.Metadata
{
    /// <summary>
    /// Environment station metadata.
    /// </summary>
    public class EnvironmentStationMetadata
    {
        [JsonPropertyName("municipality")]
        public string Municipality { get; set; }
    }
}
