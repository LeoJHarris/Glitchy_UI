namespace Glitchy_UI.Models;

public enum LightingQuality
{
    Unknown,
    TooDark,
    Good,
    TooBright
}

public sealed record FaceMetrics(
bool IsFaceCentered,
float HeadYaw,
float HeadPitch,
float EyesOpenProbability,
MauiPointF? LeftEyePosition = null,
MauiPointF? RightEyePosition = null,
float? FaceCenterXNorm = null,
float? FaceCenterYNorm = null,
LightingQuality Lighting = LightingQuality.Unknown,
float Brightness = 0f)
{
    public bool IsCompliant => Math.Abs(HeadYaw) < 5 && EyesOpenProbability > 0.85f;

    public MauiPointF? EyesCenterPosition
    {
        get
        {
            if (LeftEyePosition.HasValue && RightEyePosition.HasValue)
            {
                return new MauiPointF(
                    (LeftEyePosition.Value.X + RightEyePosition.Value.X) / 2,
                    (LeftEyePosition.Value.Y + RightEyePosition.Value.Y) / 2);
            }

            return null;
        }
    }
}