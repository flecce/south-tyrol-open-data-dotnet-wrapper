using System.Text.Json.Serialization;

namespace OpenDataWrapper.Domains.Mobility.Dto.Metadata
{
    /// <summary>
    /// Parking station metadata.
    /// </summary>
    public class ParkingStationMetadata
    {
        [JsonPropertyName("state")]
        public int State { get; set; }

        [JsonPropertyName("capacity")]
        public int Capacity { get; set; }

        [JsonPropertyName("mainaddress")]
        public string Address { get; set; }

        [JsonPropertyName("phonenumber")]
        public string PhoneNumber { get; set; }

        [JsonPropertyName("municipality")]
        public string Municipality { get; set; }

        [JsonPropertyName("disabledtoiletavailable")]
        public bool DisabledToiletAvailable { get; set; }
    }
}
