namespace Glitchy_UI.Extensions;

public static class JsonExtensions
{
    private static readonly JsonSerializerOptions parseOptions = new()
    {
        PropertyNameCaseInsensitive = true, // Optional: for case-insensitive property matching
        Converters = {
            new DateTimeConverterUsingDateTimeParse(),
            new ReauthStatusJsonConverter(),
            new AuditLogActionJsonConverter(),
            new JsonStringEnumConverter(JsonNamingPolicy.CamelCase, allowIntegerValues: true) // Allow integer values
        },
        // Add other options as needed
    };

    private static readonly JsonSerializerOptions serializeOptions = new()
    {
        ReferenceHandler = ReferenceHandler.IgnoreCycles, // Handles circular references if needed
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase, // Add this for consistent naming
        Converters = {
            new ReauthStatusJsonConverter(),
            new AuditLogActionJsonConverter(),
            new JsonStringEnumConverter(JsonNamingPolicy.CamelCase, allowIntegerValues: true) // Add enum converter here too
        }
        // Add other options as needed
    };

    public static T? ParseJson<T>(this string serializedObject) => JsonSerializer.Deserialize<T>(serializedObject, parseOptions);

    public static string ToJson<T>(this T value) => JsonSerializer.Serialize(value, serializeOptions);
}