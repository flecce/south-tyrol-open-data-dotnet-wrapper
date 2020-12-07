using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenDataWrapper.JsonConverters
{
    public class DateTimeOffsetConverter : JsonConverter<DateTimeOffset>
    {
        public override DateTimeOffset Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            var tzIndex = reader.GetString().IndexOf("+");
            return DateTimeOffset.ParseExact(
                reader.GetString().Substring(0, (tzIndex > 0 ? tzIndex : 0)),
                "yyyy-MM-dd HH:mm:ss.fff",
                CultureInfo.InvariantCulture);
        }
                

        public override void Write(
            Utf8JsonWriter writer,
            DateTimeOffset dateTimeValue,
            JsonSerializerOptions options) =>
                writer.WriteStringValue(dateTimeValue.ToString(
                    "yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture));
    }
}
