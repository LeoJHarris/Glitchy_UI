namespace Glitchy_UI.ViewModels.TabViewModels;

public partial class DisabledSitesTabViewModel(IAsyncRelayCommand refreshAction) : BaseTabViewModel
{
    [ObservableProperty]
    public partial string CurrentTabViewContentState { get; set; } = string.Empty;

    public ObservableCollection<ApplicationsGrouped<long, ApplicationViewModel>> DisabledSitesGrouped { get; set; } = [];

    [ObservableProperty]
    public partial bool IsRefreshing { get; set; }

    [ObservableProperty]
    public partial IAsyncRelayCommand RefreshCommand { get; set; } = refreshAction;
}