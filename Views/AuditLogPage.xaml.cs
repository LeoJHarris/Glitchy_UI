namespace Glitchy_UI.Views;

public partial class AuditLogPage : BasePage
{
    public AuditLogPage(AuditLogPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}