using System.Text.Json.Serialization;

namespace OpenDataWrapper.Domains.Mobility.Dto
{
    public class MobilityResponse<TMetadata>
    {
        [JsonPropertyName("sactive")]
        public bool Active { get; set; }

        [JsonPropertyName("savailable")]
        public bool Available { get; set; }

        [JsonPropertyName("scode")]
        public string Code { get; set; }

        [JsonPropertyName("sname")]
        public string Name { get; set; }

        [JsonPropertyName("stype")]
        public string Type { get; set; }

        [JsonPropertyName("sorigin")]
        public string Origin { get; set; }

        [JsonPropertyName("scoordinate")]
        public Coordinate Coordinate { get; set; }

        [JsonPropertyName("smetadata")]
        public TMetadata Metadata { get; set; }
    }

    public class MobilityResponse<TParentMetadata, TMetadata>
    {
        [JsonPropertyName("pactive")]
        public bool ParentActive { get; }

        [JsonPropertyName("pavailable")]
        public bool ParentAvailable { get; }

        [JsonPropertyName("pcode")]
        public string ParentCode { get; set; }

        [JsonPropertyName("pcoordinate")]
        public Coordinate ParentCoordinate { get; set; }

        [JsonPropertyName("pmetadata")]
        public TParentMetadata ParentMetadata { get; set; }

        [JsonPropertyName("pname")]
        public string ParentName { get; set; }

        [JsonPropertyName("porigin")]
        public string ParentOrigin { get; set; }

        [JsonPropertyName("ptype")]
        public string ParentType { get; set; }

        [JsonPropertyName("sactive")]
        public bool Active { get; set; }

        [JsonPropertyName("savailable")]
        public bool Available { get; set; }

        [JsonPropertyName("scode")]
        public string Code { get; set; }

        [JsonPropertyName("sname")]
        public string Name { get; set; }

        [JsonPropertyName("stype")]
        public string Type { get; set; }

        [JsonPropertyName("sorigin")]
        public string Origin { get; set; }

        [JsonPropertyName("scoordinate")]
        public Coordinate Coordinate { get; set; }

        [JsonPropertyName("smetadata")]
        public TMetadata Metadata { get; set; }
    }

    public class Coordinate
    {
        [JsonPropertyName("x")]
        public double X { get; set; }

        [JsonPropertyName("y")]
        public double Y { get; set; }
    }
}
