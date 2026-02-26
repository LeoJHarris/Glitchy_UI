namespace Glitchy_UI.Platforms.iOS;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    private UIVisualEffectView? _blurWindow;

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        bool result = base.FinishedLaunching(application, launchOptions);


        return result;
    }

    public override void OnActivated(UIApplication application)
    {
        base.OnActivated(application);

        _blurWindow?.RemoveFromSuperview();
        _blurWindow?.Dispose();
        _blurWindow = null;
    }

    public override void OnResignActivation(UIApplication application)
    {
        base.OnResignActivation(application);

        using UIBlurEffect blurEffect = UIBlurEffect.FromStyle(UIBlurEffectStyle.Dark);
        CGRect frame;
        UIWindowScene? windowScene = (UIWindowScene?)UIApplication.SharedApplication.ConnectedScenes.ToArray().FirstOrDefault(scene => scene is UIWindowScene);

        if (windowScene is not null)
        {
            frame = windowScene.Windows.Length > 0 && windowScene.Windows[0].RootViewController?.View is UIView uIView
                ? uIView.Bounds
                : UIScreen.MainScreen.Bounds;
        }
        else
        {
            frame = UIScreen.MainScreen.Bounds;
        }

        _blurWindow = new UIVisualEffectView(blurEffect)
        {
            Frame = frame
        };

        if (windowScene?.Windows.Length > 0)
        {
            windowScene.Windows[0].RootViewController?.View?.AddSubview(_blurWindow);
        }
    }

    public override void PerformActionForShortcutItem(UIApplication application, UIApplicationShortcutItem shortcutItem, UIOperationHandler completionHandler) => Platform.PerformActionForShortcutItem(application, shortcutItem, completionHandler);

    [Export("application:didRegisterForRemoteNotificationsWithDeviceToken:")]
    public void RegisteredForRemoteNotifications(UIApplication application, NSData deviceToken)
    {
        byte[] token = [.. deviceToken];
        string pnsDeviceToken = Convert.ToHexString(token);
    }

    public override void WillEnterForeground(UIApplication uiApplication)
    {
        base.WillEnterForeground(uiApplication);
    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

}