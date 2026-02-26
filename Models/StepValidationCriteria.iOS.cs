#if IOS || MACCATALYST
namespace Glitchy_UI.Models;

public sealed partial record StepValidationCriteria
{
    // iOS yaw calibration with +145 scale: wider ranges for easier capture
    // Physical left turn increases centerX (face moves right in frame), producing positive yaw
    // Physical right turn decreases centerX (face moves left in frame), producing negative yaw
    public static StepValidationCriteria LookLeft => new(
        MinYaw: 0.5f,
        MaxYaw: 7f,
        MinPitch: -8f,
        MaxPitch: 8f,
        MinEyesOpen: 0.5f,
        RequireFaceCentered: false,
        AllowMirroredYaw: false);

    public static StepValidationCriteria LookRight => new(
        MinYaw: -7f,
        MaxYaw: -0.5f,
        MinPitch: -8f,
        MaxPitch: 8f,
        MinEyesOpen: 0.5f,
        RequireFaceCentered: false,
        AllowMirroredYaw: false);

    // iOS pitch calibration tuning - requires noticeable head movement
    public static StepValidationCriteria LookDown => new(
        MinYaw: -8f,
        MaxYaw: 8f,
        MinPitch: 0.5f,
        MaxPitch: 9f,
        RequireFaceCentered: false,
        AllowMirroredPitch: false);

    public static StepValidationCriteria LookUp => new(
        MinYaw: -8f,
        MaxYaw: 8f,
        MinPitch: -9f,
        MaxPitch: -0.5f,
        RequireFaceCentered: false,
        AllowMirroredPitch: false);
}
#endif