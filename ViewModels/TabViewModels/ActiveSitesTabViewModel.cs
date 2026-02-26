namespace Glitchy_UI.ViewModels.TabViewModels;

public partial class ActiveSitesTabViewModel(IAsyncRelayCommand refreshAction) : BaseTabViewModel
{
    public ObservableCollection<ApplicationsGrouped<long, ApplicationViewModel>> ActiveSitesGrouped { get; set; } = [];

    [ObservableProperty]
    public partial string CurrentTabViewContentState { get; set; } = string.Empty;

    [ObservableProperty]
    public partial bool IsRefreshing { get; set; }

    [ObservableProperty]
    public partial IAsyncRelayCommand RefreshCommand { get; set; } = refreshAction;
}