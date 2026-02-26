namespace Glitchy_UI.Views;

public partial class NotificationsPage : BasePage
{
    public NotificationsPage()
        : this(App.ServiceProvider.GetRequiredService<NotificationsPageViewModel>())
    {
    }

    public NotificationsPage(NotificationsPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}