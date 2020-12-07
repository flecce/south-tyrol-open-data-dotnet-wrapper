using System.Text.Json.Serialization;

namespace OpenDataWrapper.Domains.Mobility.Dto
{
    public class Coordinate
    {
        [JsonPropertyName("x")]
        public double X { get; set; }

        [JsonPropertyName("y")]
        public double Y { get; set; }
    }
}
