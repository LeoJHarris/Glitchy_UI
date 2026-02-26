namespace Glitchy_UI.Views;

public partial class ApplicationsPage : BasePage
{
    public ApplicationsPage(ApplicationsPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}