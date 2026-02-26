namespace Glitchy_UI.Extensions;

/// <summary>
/// Provides extension methods for various utility functions.
/// </summary>
public static partial class Extensions
{
    /// <summary>
    /// Gets the types in the specified namespace from the given assembly.
    /// </summary>
    /// <param name="assembly">The assembly to search.</param>
    /// <param name="nameSpace">The namespace to search within.</param>
    /// <returns>An enumerable of types in the specified namespace.</returns>
    public static IEnumerable<Type> GetTypesInNamespace(Assembly assembly, string nameSpace) => assembly.GetTypes().Where(t => string.Equals(t.Namespace, nameSpace, StringComparison.Ordinal));

    public static string RemoveNonNumbers(this string value) =>
        string.IsNullOrEmpty(value.Trim()) ? string.Empty : MyRegex().Replace(value, string.Empty);

    /// <summary>
    /// Sends an HTTP request asynchronously and parses the response into an object of type T.
    /// </summary>
    /// <typeparam name="T">The type of the object to parse from the response.</typeparam>
    /// <param name="httpRequestMessage">The HTTP request message to send.</param>
    /// <param name="httpClient">The HTTP client to use for sending the request.</param>
    /// <returns>The parsed object of type T, or null if the request fails.</returns>
    public static async Task<T?> SendRequestAsync<T>(this HttpRequestMessage httpRequestMessage, HttpClient httpClient) where T : class
    {
        try
        {
            using HttpResponseMessage response = await httpClient.SendAsync(httpRequestMessage).ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                if (string.IsNullOrWhiteSpace(json))
                {
                    return null;
                }

#if DEBUG
                if (typeof(T) == typeof(Reauth))
                {
                    Debug.WriteLine($"Reauth JSON ({httpRequestMessage.Method} {httpRequestMessage.RequestUri}): {json}");
                }
#endif

                return json.ParseJson<T>();
            }
            else
            {
                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    Debug.WriteLine($"API NotFound ({httpRequestMessage.Method} {httpRequestMessage.RequestUri})");
                    return null;
                }

                await handleErrorResponseAsync(response).ConfigureAwait(false);
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"API call failed: {ex}");
            throw; // Re-throw the exception
        }
    }

    /// <summary>
    /// Writes the exception details to the debug output.
    /// </summary>
    /// <param name="value">The exception to write.</param>
    public static void WriteLine(this Exception value)
    {
        Debug.WriteLine("Start Main Exception".ToUpper() + "########################################");
        Debug.WriteLine(value.ToString());
        Debug.WriteLine("End Main Exception".ToUpper() + "########################################");
        Exception originalException = value;
        while (originalException.InnerException is not null)
        {
            originalException = originalException.InnerException;

            Debug.WriteLine("Start Inner Exception".ToUpper() + "########################################");
            Debug.WriteLine(originalException.ToString());
            Debug.WriteLine("End Inner Exception".ToUpper() + "########################################");
        }
    }

    /// <summary>
    /// Handles the error response from an HTTP request.
    /// </summary>
    /// <param name="response">The HTTP response message containing the error.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    /// <exception cref="ApiException">Thrown when an error occurs while processing the response.</exception>
    private static async Task handleErrorResponseAsync(HttpResponseMessage response)
    {
        try
        {
            string errorContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            // Log the raw error content for debugging
            Debug.WriteLine($"API Error Response ({response.StatusCode}): {errorContent}");

            ApiErrorResponse? errorResponse = JsonSerializer.Deserialize<ApiErrorResponse>(errorContent);

            if (errorResponse != null)
            {
                throw new ApiException($"{errorResponse.Message} (HTTP {response.StatusCode})", response.StatusCode, errorResponse);
            }
            else
            {
                throw new ApiException($"HTTP error {response.StatusCode}: {errorContent}", response.StatusCode);
            }
        }
        catch (JsonException jsonEx)
        {
            string content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            throw new ApiException($"HTTP error {response.StatusCode}. Failed to parse error response: {content}", response.StatusCode);
        }
        catch (ArgumentOutOfRangeException argEx)
        {
            throw new ApiException($"HTTP error: {response.StatusCode} - {argEx.Message}", response.StatusCode);
        }
    }

    /// <summary>
    /// A compiled regular expression for removing non-numeric characters.
    /// </summary>
    /// <returns>A <see cref="Regex"/> instance.</returns>
    [GeneratedRegex(@"[^\d]")]
    private static partial Regex MyRegex();
}