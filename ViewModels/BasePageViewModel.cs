namespace Glitchy_UI.ViewModels;

/// <summary>
/// Base view model for all page view models - provides common page state and refresh functionality.
/// </summary>
public abstract partial class BasePageViewModel : ObservableObject
{
    [ObservableProperty]
    private string _currentPageState = string.Empty;

    [ObservableProperty]
    private bool _hasInternetAccess = true;

    [ObservableProperty]
    private bool _isRefreshing;

    [RelayCommand]
    protected virtual Task PullToRefreshPageAsync() => Task.CompletedTask;

    [RelayCommand]
    protected virtual Task RefreshPageAsync() => Task.CompletedTask;
}
