namespace Glitchy_UI.Models.ViewModels;

public partial class LocalNotificationViewModel(string title, string message) : ObservableObject
{
    [ObservableProperty]
    public partial string? ASU { get; set; } = string.Empty;

    public IRelayCommand<LocalNotificationViewModel>? DeleteNotificationCommand { get; set; }

    [ObservableProperty]
    public partial string Message { get; set; } = message;

    [ObservableProperty]
    public partial long? MfaId { get; set; }

    [ObservableProperty]
    public partial NotificationType NotificationType { get; set; }

    public IRelayCommand<LocalNotificationViewModel>? OpenNotificationCommand { get; set; }

    [ObservableProperty]
    public partial long? ReauthId { get; set; }

    [ObservableProperty]
    public partial DateTimeOffset ReceivedDateTimeOffset { get; set; } = DateTimeOffset.UtcNow;

    [ObservableProperty]
    public partial long ReceivedDateUnixSeconds { get; set; }

    [ObservableProperty]
    public partial string Title { get; set; } = title;
}

public enum NotificationType
{
    ReauthRequest,
    MfaRequest,
    MfaSiteRequest,
    LockedOut,
}