namespace Glitchy_UI.JsonConverters;

public sealed class ReauthStatusJsonConverter : JsonConverter<ReauthStatus>
{
    public override ReauthStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Number)
        {
            return reader.TryGetInt32(out int intValue) && Enum.IsDefined(typeof(ReauthStatus), intValue)
                ? (ReauthStatus)intValue
                : throw new JsonException($"Invalid numeric value for {nameof(ReauthStatus)}.");
        }

        if (reader.TokenType != JsonTokenType.String)
        {
            throw new JsonException($"Unexpected token parsing {nameof(ReauthStatus)}. Token: {reader.TokenType}.");
        }

        string? value = reader.GetString();
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new JsonException($"Empty value for {nameof(ReauthStatus)}.");
        }

        if (Enum.TryParse<ReauthStatus>(value, ignoreCase: true, out var parsed))
        {
            return parsed;
        }

        // Handle values that are camelCase/lowercase as per API contract.
        // Enum.TryParse(ignoreCase:true) already covers these, but keep a fallback for future
        // non-standard values.
        throw new JsonException($"Unable to convert '{value}' to {nameof(ReauthStatus)}.");
    }

    public override void Write(Utf8JsonWriter writer, ReauthStatus value, JsonSerializerOptions options) =>
        // API contract uses lowercase string values.
        writer.WriteStringValue(value.ToString().ToLowerInvariant());
}