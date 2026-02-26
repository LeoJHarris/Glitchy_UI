namespace Glitchy_UI;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        ILogger<App> logger = ServiceProvider.GetRequiredService<ILogger<App>>();
        logger.LogInformation("App ctor. Sample data mode - bypassing auth. process={ProcessId} thread={ThreadId}",
            Environment.ProcessId, Environment.CurrentManagedThreadId);
    }

    public static IServiceProvider ServiceProvider => IPlatformApplication.Current!.Services;

    protected override Window CreateWindow(IActivationState? activationState)
    {
        ILogger<App> logger = ServiceProvider.GetRequiredService<ILogger<App>>();
        logger.LogInformation("CreateWindow. Going directly to AppShell with sample data.");

        // Go directly to AppShell - no login/auth required
        return new Window(new AppShell());
    }

}