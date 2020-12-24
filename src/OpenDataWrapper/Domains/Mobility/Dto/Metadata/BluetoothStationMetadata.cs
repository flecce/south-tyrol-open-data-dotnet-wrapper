using System.Text.Json.Serialization;

namespace OpenDataWrapper.Domains.Mobility.Dto.Metadata
{
    /// <summary>
    /// Bluetooth station metadata.
    /// </summary>
    public class BluetoothStationMetadata
    {
        [JsonPropertyName("municipality")]
        public string Municipality { get; set; }
    }
}
