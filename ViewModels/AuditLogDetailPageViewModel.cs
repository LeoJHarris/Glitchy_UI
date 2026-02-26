namespace Glitchy_UI.ViewModels;

/// <summary>
/// Minimal AuditLogDetailPageViewModel for TabBar UI reproduction.
/// </summary>
public partial class AuditLogDetailPageViewModel : BasePageViewModel, IQueryAttributable
{
    public AuditLogDetailPageViewModel()
    {
        CurrentPageState = "Success";
    }

    [ObservableProperty]
    public partial AuditLogAction Action { get; set; } = AuditLogAction.Unknown;

    [ObservableProperty]
    public partial string ActionDescription { get; set; } = string.Empty;

    public string ActionDisplay => "Sample Action";

    [ObservableProperty]
    public partial string AppName { get; set; } = "Sample App";

    [ObservableProperty]
    public partial long? AuditLogId { get; set; }

    [ObservableProperty]
    public partial string IpAddress { get; set; } = "192.168.1.1";

    [ObservableProperty]
    public partial DateTimeOffset? LogDate { get; set; } = DateTimeOffset.Now;

    [ObservableProperty]
    public partial string SiteName { get; set; } = "Sample Site";

    [ObservableProperty]
    public partial string UserName { get; set; } = "Sample User";

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        // Minimal implementation for TabBar reproduction
    }

    [RelayCommand]
    private Task LoadAsync()
    {
        CurrentPageState = "Success";
        return Task.CompletedTask;
    }

    [RelayCommand]
    private Task PullToRefreshAsync()
    {
        IsRefreshing = false;
        return Task.CompletedTask;
    }
}
