namespace Glitchy_UI;

/// <summary>
/// Minimal AppShellViewModel for TabBar UI reproduction.
/// No service dependencies - completely self-contained.
/// </summary>
public partial class AppShellViewModel : ObservableObject
{
    public AppShellViewModel()
    {
        // No dependencies needed for minimal reproduction
        Username = "Test User";
    }

    [ObservableProperty]
    public partial string? ASU { get; set; }

    [ObservableProperty]
    public partial bool IsDemoModeEnabled { get; set; } = true;

    [ObservableProperty]
    public partial long? MfaId { get; set; }

    [ObservableProperty]
    public partial long? ReauthId { get; set; }

    public string UserHandle => string.IsNullOrWhiteSpace(Username)
        ? string.Empty
        : $"@{Username.Replace(" ", string.Empty).ToLowerInvariant()}";

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(UserHandle))]
    public partial string Username { get; set; } = string.Empty;

    [RelayCommand]
    private Task NotificationsMenuItemTappedAsync()
    {
        Shell.Current.FlyoutIsPresented = false;
        return Shell.Current.GoToAsync("notifications", true);
    }

    [RelayCommand]
    private Task MobilityWalletMenuItemTappedAsync()
    {
        Shell.Current.FlyoutIsPresented = false;
        return Shell.Current.GoToAsync("mobilitywallet");
    }

    [RelayCommand]
    private Task OnNavigatedAsync(ShellNavigatedEventArgs? shellNavigatedEventArgs)
    {     // No-op for minimal reproduction, but this is where you would handle any logic that needs to occur after navigation.
        return Task.CompletedTask;
    }

    [RelayCommand]
    private Task ProfileMenuItemTappedAsync()
    {
        Shell.Current.FlyoutIsPresented = false;
        return Shell.Current.GoToAsync("profile", true);
    }

    [RelayCommand]
    private Task SettingsMenuItemTappedAsync()
    {
        Shell.Current.FlyoutIsPresented = false;
        return Shell.Current.GoToAsync("settings");
    }
}