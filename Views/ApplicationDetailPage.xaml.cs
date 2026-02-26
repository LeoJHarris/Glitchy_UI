namespace Glitchy_UI.Views;

public partial class ApplicationDetailPage : BasePage
{
    public ApplicationDetailPage(ApplicationDetailPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}