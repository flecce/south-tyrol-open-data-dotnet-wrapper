using System.Text.Json.Serialization;

namespace OpenDataWrapper.Domains.Mobility.Dto.Metadata
{
    public class BicycleStationMetadata
    {
        [JsonPropertyName("municipality")]
        public string Municipality { get; set; }

        [JsonPropertyName("bikes")]
        public BikeData Bikes { get; set; }
    }

    public class BicycleMetadata
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

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
