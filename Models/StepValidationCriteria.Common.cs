namespace Glitchy_UI.Models;

public sealed partial record StepValidationCriteria
{
    public static StepValidationCriteria CenterFace => new(
        MinYaw: -7f,
        MaxYaw: 7f,
        MinPitch: -7f,
        MaxPitch: 7f,
        RequireFaceCentered: true);
}