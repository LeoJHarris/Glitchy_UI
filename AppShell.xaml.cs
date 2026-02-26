namespace Glitchy_UI;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        AppRoutes.Register();

        BindingContext = App.ServiceProvider.GetRequiredService<AppShellViewModel>();
    }
}