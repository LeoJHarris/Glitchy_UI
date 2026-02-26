namespace Glitchy_UI.Platforms.iOS;

public class Program
{
    /// <summary>
    /// This is the main entry point of the application.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        // if you want to use a different Application Delegate class from "AppDelegate" you can
        // specify it here.

        try
        {
            UIApplication.Main(args, null, typeof(AppDelegate));
        }
        catch (Exception ex)
        {
            IServiceProvider? serviceProvider = IPlatformApplication.Current?.Services;
            if (serviceProvider is not null)
            {
                ILoggerProvider loggerProvider = serviceProvider.GetRequiredService<ILoggerProvider>();
                var logger = loggerProvider.CreateLogger(nameof(Activity));
                logger.LogError(ex, "An error occurred while starting the application.");
            }

            Console.WriteLine(ex);
        }
    }
}