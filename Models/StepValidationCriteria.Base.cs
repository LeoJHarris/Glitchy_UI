namespace Glitchy_UI.Models;

public sealed partial record StepValidationCriteria(
    float MinYaw = -15f,
    float MaxYaw = 15f,
    float MinPitch = -15f,
    float MaxPitch = 15f,
    float MinEyesOpen = 0.8f,
    bool RequireFaceCentered = true,
    bool AllowMirroredYaw = false,
    bool AllowMirroredPitch = false)
{
    public static StepValidationCriteria Default => new();

    public bool IsMetricsCompliant(FaceMetrics metrics)
    {
        if (RequireFaceCentered && !metrics.IsFaceCentered)
        {
            return false;
        }

        float yaw = metrics.HeadYaw;
        bool yawOk = yaw >= MinYaw && yaw <= MaxYaw;

        if (!yawOk && AllowMirroredYaw)
        {
            float absYaw = Math.Abs(yaw);
            yawOk = absYaw >= MinYaw && absYaw <= MaxYaw;
        }

        if (!yawOk)
        {
            return false;
        }

        float pitch = metrics.HeadPitch;
        bool pitchOk = pitch >= MinPitch && pitch <= MaxPitch;

        if (!pitchOk && AllowMirroredPitch)
        {
            float mirroredMinPitch = -MaxPitch;
            float mirroredMaxPitch = -MinPitch;

            pitchOk = pitch >= mirroredMinPitch && pitch <= mirroredMaxPitch;
        }

        if (!pitchOk)
        {
            return false;
        }

        if (metrics.EyesOpenProbability < MinEyesOpen)
        {
            return false;
        }

        return true;
    }
}