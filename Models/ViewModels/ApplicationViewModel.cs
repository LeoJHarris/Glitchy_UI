namespace Glitchy_UI.Models.ViewModels;

public partial class ApplicationViewModel() : ObservableObject
{
    [ObservableProperty]
    public partial long ApplicationID { get; set; }

    [ObservableProperty]
    public partial string? ApplicationLogo { get; set; } = string.Empty;

    [ObservableProperty]
    public partial string ApplicationName { get; set; } = string.Empty;

    [ObservableProperty]
    public partial bool Enabled { get; set; }

    [ObservableProperty]
    public partial DateTimeOffset LastSignedIn { get; set; }

    public Site? Site { get; set; }

    [ObservableProperty]
    public partial string SiteName { get; set; } = string.Empty;

    [ObservableProperty]
    public partial DateTimeOffset? LastSignInSuccess { get; set; }

    [ObservableProperty]
    public partial DateTimeOffset? LastSignInFailure { get; set; }

    [ObservableProperty]
    public partial DateTimeOffset? LastReauth { get; set; }

    [ObservableProperty]
    public partial DateTimeOffset? LastMfaCompleted { get; set; }

    [ObservableProperty]
    public partial DateTimeOffset? AccessStartDate { get; set; }

    [ObservableProperty]
    public partial DateTimeOffset? AccessEndDate { get; set; }

    public bool HasLogo => !string.IsNullOrWhiteSpace(ApplicationLogo);

    public string EffectiveLastSignedInLabel
        => LastSignInSuccess is not null
            ? $"{LastSignInSuccess.Value:dd MMMM, yyyy}"
            : $"{LastSignedIn:dd MMMM, yyyy}";

    [RelayCommand]
    private Task OptionsTappedAsync()
    {
        return Task.CompletedTask;
    }
}