namespace Glitchy_UI.DependencyInjection;

public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Registers only the minimal pages needed for TabBar UI reproduction.
    /// </summary>
    public static IServiceCollection AddGlitchy_UIPages(this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services);

        return services
            // Tab pages - the 3 pages in AppShell TabBar
            .AddTransient<DashboardPage>()
            .AddTransient<DashboardPageViewModel>()
            .AddTransient<ApplicationsPage>()
            .AddTransient<ApplicationsPageViewModel>()
            .AddTransient<AuditLogPage>()
            .AddTransient<AuditLogPageViewModel>()
            // AppShell
            .AddSingleton<AppShell>()
            .AddSingleton<AppShellViewModel>();
    }
}
