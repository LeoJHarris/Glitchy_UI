namespace Glitchy_UI.Views;

public partial class DashboardPage : BasePage
{
    public DashboardPage(DashboardPageViewModel dashboardPageViewModel)
    {
        InitializeComponent();
        BindingContext = dashboardPageViewModel;
    }
}