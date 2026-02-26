namespace Glitchy_UI.JsonConverters;

/// <summary>
/// Custom DateTime converter for "u" format
/// </summary>
public class DateTimeConverterUsingDateTimeParse : JsonConverter<DateTime>
{
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            if (DateTime.TryParse(reader.GetString(), out DateTime dateTime))
            {
                return dateTime;
            }
        }

        return DateTime.MinValue; // Or throw an exception if invalid
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options) => writer.WriteStringValue(value.ToString("u"));
}