namespace Glitchy_UI.ViewModels;

/// <summary>
/// Minimal NotificationsPageViewModel for TabBar UI reproduction.
/// </summary>
public partial class NotificationsPageViewModel : BasePageViewModel, IDisposable
{
    public NotificationsPageViewModel()
    {
        CurrentPageState = "Success";
    }

    public ObservableCollection<object> NotificationsGroupedCollection { get; set; } = [];
    public ObservableCollection<object> NotificationsViewModels { get; set; } = [];

    private bool _disposed;

    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
        {
            return;
        }

        if (disposing)
        {
            // Cleanup if needed
        }

        _disposed = true;
    }

    protected override Task PullToRefreshPageAsync()
    {
        IsRefreshing = false;
        return Task.CompletedTask;
    }

    protected override Task RefreshPageAsync()
    {
        CurrentPageState = "Success";
        IsRefreshing = false;
        return Task.CompletedTask;
    }

    [RelayCommand]
    private Task ClosePageAsync() => Shell.Current.GoToAsync("..");
}
