using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenDataWrapper.Domains.Mobility.Dto
{
    public class ChargingStation
    {
        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("capacity")]
        public int Capacity { get; set; }

        [JsonPropertyName("provider")]
        public string Provider { get; set; }
    }


    public class ChargingPlug
    {
        [JsonPropertyName("outlets")]
        public List<Outlet> Outlets { get; set; }
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
