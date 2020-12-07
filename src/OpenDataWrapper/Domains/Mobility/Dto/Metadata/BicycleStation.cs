using System.Text.Json.Serialization;

namespace OpenDataWrapper.Domains.Mobility.Dto.Metadata
{
    /// <summary>
    /// Bicycle station metadata.
    /// </summary>
    public class BicycleStationMetadata
    {
        [JsonPropertyName("municipality")]
        public string Municipality { get; set; }

        [JsonPropertyName("bikes")]
        public BikeData Bikes { get; set; }
    }

    /// <summary>
    /// Bicycle metadata.
    /// </summary>
    public class BicycleMetadata
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    /// <summary>
    /// Bike data.
    /// </summary>
    public class BikeData
    {
        [JsonPropertyName("number-available")]
        public int Available { get; set; }

        [JsonPropertyName("mountain-bike-adult")]
        public int MountainBikeAdult { get; set; }

        [JsonPropertyName("mountain-bike-child")]
        public int MuntainBikeChild { get; set; }

        [JsonPropertyName("mountain-bike-teenager")]
        public int MountainBikeTeenager { get; set; }

        [JsonPropertyName("city-bike-adult-with-gears")]
        public int CityBikeAdultWithGears { get; set; }

        [JsonPropertyName("city-bike-adult-without-gears")]
        public int CityBikeAdultWithoutGears { get; set; }
    }
}
