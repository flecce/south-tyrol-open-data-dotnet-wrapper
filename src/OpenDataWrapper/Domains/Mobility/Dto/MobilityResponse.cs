using OpenDataWrapper.JsonConverters;
using System;
using System.Text.Json.Serialization;

namespace OpenDataWrapper.Domains.Mobility.Dto
{
    /// <summary>
    /// Station type response.
    /// </summary>
    /// <typeparam name="TMetadata">Parent station metadata type.</typeparam>
    public class MobilityStationTypeResponse<TMetadata> where TMetadata : class
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

    /// <summary>
    /// Station type respose.
    /// </summary>
    /// <typeparam name="TParentMetadata">Parent metadata type.</typeparam>
    /// <typeparam name="TMetadata">Station metadata type.</typeparam>
    public class MobilityStationTypeResponse<TParentMetadata, TMetadata>
        where TParentMetadata : class
        where TMetadata : class
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

    /// <summary>
    /// Data type response.
    /// </summary>
    /// <typeparam name="TMetadata">Data type metadata.</typeparam>
    public class MobilityDataTypeResponse<TMetadata> where TMetadata : class
    {
        [JsonPropertyName("tdescription")]
        public string TypeDescription { get; set; }

        [JsonPropertyName("tmetadata")]
        public TMetadata TypeMetadata { get; set; }

        [JsonPropertyName("tname")]
        public string Name { get; set; }

        [JsonPropertyName("ttype")]
        public string Type { get; set; }

        [JsonPropertyName("tunit")]
        public string Unit { get; set; }

        [JsonPropertyName("mperiod")]
        public int Period { get; set; }

        [JsonPropertyName("mtransactiontime")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset TransactionType { get; set; }

        [JsonPropertyName("mvalidtime")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset ValidTime { get; set; }

        [JsonPropertyName("mvalue")]
        public double Value { get; set; }
    }
}
