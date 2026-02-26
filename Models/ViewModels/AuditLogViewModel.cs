namespace Glitchy_UI.Models.ViewModels;

public partial class AuditLogViewModel : ObservableObject
{
    [ObservableProperty]
    public partial AuditLogAction Action { get; set; } = AuditLogAction.Unknown;

    public string ActionDisplay => Glitchy_UI.Helpers.EnumDisplayName.Get(Action);

    [ObservableProperty]
    public partial string AppName { get; set; } = string.Empty;

    [ObservableProperty]
    public partial long AuditLogID { get; set; }

    [ObservableProperty]
    public partial string IpAddress { get; set; } = string.Empty;

    [ObservableProperty]
    public partial DateTimeOffset? LogDate { get; set; }

    public DateOnly? LogDateOnly => LogDate?.ToLocalTime() is DateTimeOffset dto
        ? DateOnly.FromDateTime(dto.DateTime)
        : null;

    public IRelayCommand<AuditLogViewModel>? OpenAuditLogDetailCommand { get; set; }

    [ObservableProperty]
    public partial string SiteName { get; set; } = string.Empty;

    [ObservableProperty]
    public partial string UserName { get; set; } = string.Empty;

    partial void OnActionChanged(AuditLogAction value)
    {
        OnPropertyChanged(nameof(ActionDisplay));
    }
}