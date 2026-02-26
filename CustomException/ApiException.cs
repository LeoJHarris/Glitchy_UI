namespace Glitchy_UI.CustomException;

public class ApiException : Exception
{
    public ApiException(string message, HttpStatusCode? statusCode, ApiErrorResponse? errorResponse = null, Exception? innerException = null)
        : base(message, innerException)
    {
        StatusCode = statusCode;
        ErrorResponse = errorResponse;
    }

    public ApiException() : base()
    {
    }

    public ApiException(string? message) : base(message)
    {
    }

    public ApiException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    public ApiErrorResponse? ErrorResponse { get; }
    public HttpStatusCode? StatusCode { get; }
}