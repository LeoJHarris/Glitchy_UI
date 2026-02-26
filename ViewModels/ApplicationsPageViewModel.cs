namespace Glitchy_UI.ViewModels;

/// <summary>
/// Minimal ApplicationsPageViewModel for TabBar UI reproduction.
/// </summary>
public partial class ApplicationsPageViewModel : BasePageViewModel
{
    public ApplicationsPageViewModel()
    {
        ActiveSitesTabViewModel = new ActiveSitesTabViewModel(RefreshPageCommand);
        DisabledSitesTabViewModel = new DisabledSitesTabViewModel(RefreshPageCommand);

        CurrentPageState = StateKey.Success;
    }

    public ActiveSitesTabViewModel ActiveSitesTabViewModel { get; }
    public DisabledSitesTabViewModel DisabledSitesTabViewModel { get; }

    [ObservableProperty]
    public partial int SelectedViewModelIndex { get; set; }

    protected override Task PullToRefreshPageAsync()
    {
        IsRefreshing = false;
        return Task.CompletedTask;
    }

    protected override Task RefreshPageAsync()
    {
        CurrentPageState = StateKey.Success;
        return Task.CompletedTask;
    }
}
