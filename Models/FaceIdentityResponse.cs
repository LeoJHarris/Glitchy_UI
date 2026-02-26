namespace Glitchy_UI.Models;

public sealed record FaceIdentityResponse(long UserId, string? FaceImageBase64, bool IsMatch);