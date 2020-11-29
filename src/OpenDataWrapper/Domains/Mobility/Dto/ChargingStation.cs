using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenDataWrapper.Domains.Mobility.Dto
{
    public class ChargingStation
    {
        [JsonPropertyName("city")]
        public string City { get; }

        [JsonPropertyName("state")]
        public string State { get; }

        [JsonPropertyName("address")]
        public string Address { get; }

        [JsonPropertyName("capacity")]
        public int Capacity { get; }

        [JsonPropertyName("provider")]
        public string Provider { get; }
    }


    public class ChargingPlug
    {
        [JsonPropertyName("outlets")]
        public List<Outlet> Outlets { get; }
    }

    public class Outlet
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("maxPower")]
        public int MaxPower { get; set; }

        [JsonPropertyName("minCurrent")]
        public int MinCurrent { get; set; }

        [JsonPropertyName("hasFixedCable")]
        public int HasFixedCable { get; set; }

        [JsonPropertyName("outletTypeCode")]
        public int OutletTypeCode { get; set; }
    }
}
