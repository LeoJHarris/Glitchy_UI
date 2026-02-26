namespace Glitchy_UI.Views;

public partial class AuditLogDetailPage
{
    public AuditLogDetailPage(AuditLogDetailPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}