#if ANDROID

namespace Glitchy_UI.Models;

public sealed partial record StepValidationCriteria
{
    // Android (ML Kit) tuning - lowered MinEyesOpen to 0.3 to reduce false "open your eyes" prompts
    // when users glance at instructions at the bottom of the screen
    public static StepValidationCriteria LookLeft => new(
        MinYaw: 6f,
        MaxYaw: 32f,
        MinPitch: -8f,
        MaxPitch: 8f,
        MinEyesOpen: 0.25f,
        RequireFaceCentered: false,
        AllowMirroredYaw: false);

    public static StepValidationCriteria LookRight => new(
        MinYaw: -32f,
        MaxYaw: -6f,
        MinPitch: -8f,
        MaxPitch: 8f,
        MinEyesOpen: 0.25f,
        RequireFaceCentered: false,
        AllowMirroredYaw: false);

    // LookDown: Lower threshold (0.15) because eyelids naturally cover more of the pupil
    // when tilting head downward, causing false "open your eyes" prompts
    public static StepValidationCriteria LookDown => new(
        MinYaw: -8f,
        MaxYaw: 8f,
        MinPitch: 10f,
        MaxPitch: 28f,
        MinEyesOpen: 0.15f,
        RequireFaceCentered: true,
        AllowMirroredPitch: false);

    public static StepValidationCriteria LookUp => new(
        MinYaw: -8f,
        MaxYaw: 8f,
        MinPitch: -28f,
        MaxPitch: -10f,
        MinEyesOpen: 0.25f,
        RequireFaceCentered: true,
        AllowMirroredPitch: false);
}

#endif