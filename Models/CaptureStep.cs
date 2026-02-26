namespace Glitchy_UI.Models;

public partial class CaptureStep(int stepNumber, string instructionText, StepValidationCriteria? criteria = null) : ObservableObject
{
    [ObservableProperty]
    public partial byte[]? CapturedImage { get; set; }

    [ObservableProperty]
    public partial FaceMetrics? CapturedMetrics { get; set; }

    public string InstructionText { get; } = instructionText;
    public bool IsCapturing => StepNumber <= 5;

    [ObservableProperty]
    public partial bool IsCompleted { get; set; }

    public bool IsReviewStep => StepNumber == 6;
    public int StepNumber { get; } = stepNumber;
    public StepValidationCriteria ValidationCriteria { get; } = criteria ?? StepValidationCriteria.Default;
}