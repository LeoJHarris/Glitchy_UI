// Minimal MauiProgram for TabBar UI reproduction
using CommunityToolkit.Maui;
using Sharpnado.Tabs;
using Syncfusion.Maui.Toolkit.Hosting;

namespace Glitchy_UI;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        MauiAppBuilder builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureEssentials() // Essential MAUI configuration
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "RegularFont");
                fonts.AddFont("OpenSans-Light.ttf", "LightFont");
                fonts.AddFont("OpenSans-Semibold.ttf", "SemiboldFont");
                fonts.AddFont("MaterialDesignIcons.ttf", "MaterialDesignIcons");
            }).UseMauiCommunityToolkit().ConfigureSyncfusionToolkit()
            .UseSharpnadoTabs(loggerEnable: false);

        builder.Services.AddLogging(configure =>
        {
#if DEBUG
            configure.AddDebug().AddFilter("Glitchy_UI", LogLevel.Debug);
#endif
        });

        // MINIMAL REGISTRATION - only what's needed for TabBar UI reproduction
        _ = builder.Services
            .AddGlitchy_UIPages();

        return builder.Build();
    }
}