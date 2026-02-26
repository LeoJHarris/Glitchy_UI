#if ANDROID


using CommunityToolkit.Maui.PlatformConfiguration.AndroidSpecific;

#elif IOS

using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

#endif

using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core;

namespace Glitchy_UI.Views;

public class BasePage : ContentPage
{
    private bool _isWrappingContent;


    public BasePage()
    {
#if IOS
        _ = On<Microsoft.Maui.Controls.PlatformConfiguration.iOS>().SetUseSafeArea(true);
#endif
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

#if ANDROID || IOS
        if (!Behaviors.Any(b => b is StatusBarBehavior))
        {
            Behaviors.Add(new StatusBarBehavior
            {
                StatusBarColor = (Color?)Application.Current?.Resources["PrimaryDark"] ?? Colors.White,
                StatusBarStyle = StatusBarStyle.LightContent
            });
        }
#endif
    }

}