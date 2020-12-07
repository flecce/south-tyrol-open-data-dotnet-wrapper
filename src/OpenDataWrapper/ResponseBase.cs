using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenDataWrapper
{
    public class ResponseBase<T>
    {
        [JsonPropertyName("offset")]
        public int Offset { get; set; }

        [JsonPropertyName("limit")]
        public int Limit { get; set; }

        [JsonPropertyName("data")]
        public List<T> Data { get; set; }
    }
}
