using Android.OS;

namespace Glitchy_UI;

[Activity(
    Theme = "@style/Maui.SplashTheme",
    MainLauncher = true,
    LaunchMode = LaunchMode.SingleTop,
    ScreenOrientation = ScreenOrientation.Portrait,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {

        base.OnCreate(savedInstanceState);
    }

    private static string? TryBuildLocalNotificationFromFcm(string inAppMessage, string source)
    {
        try
        {
            string[] parts = inAppMessage.Split(':');
            if (parts.Length != 2)
            {
                Android.Util.Log.Warn("MainActivity", $"#####Glitchy_UI##### {source}. FCM inAppMessage format unexpected (expected 'TYPE:ID'): {inAppMessage}");
                return null;
            }

            string messageType = parts[0].ToUpperInvariant();
            string messageValue = parts[1];

            string notificationType = messageType switch
            {
                "MFA" => "MfaRequest",
                "REAUTH" => "ReauthRequest",
                "ASU" => "MfaSiteRequest",
                _ => null
            };

            if (notificationType == null)
            {
                Android.Util.Log.Warn("MainActivity", $"#####Glitchy_UI##### {source}. FCM inAppMessage type not recognized: {messageType}");
                return null;
            }

            // Build LocalNotification JSON matching the DataContract used by
            // LocalStorageService.GetTempLocalNotification(). Important:
            // - notificationType must match enum names (e.g., "MfaRequest")
            // - received must be unix seconds (DataMember Name = "received")
            long received = System.DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            string json = messageType switch
            {
                "MFA" when long.TryParse(messageValue, out long mfaId) =>
                    $$"""{"asu":"","message":"","mfaId":{{mfaId}},"notificationType":"{{notificationType}}","reauthId":null,"received":{{received}}}""",

                "REAUTH" when long.TryParse(messageValue, out long reauthId) =>
                    $$"""{"asu":"","message":"","mfaId":null,"notificationType":"{{notificationType}}","reauthId":{{reauthId}},"received":{{received}}}""",

                "ASU" =>
                    $$"""{"asu":"{{messageValue}}","message":"","mfaId":null,"notificationType":"{{notificationType}}","reauthId":null,"received":{{received}}}""",

                _ => null
            };

#if DEBUG
            if (json != null)
            {
                Android.Util.Log.Info("MainActivity", $"#####Glitchy_UI##### {source}. synthesized LocalNotification JSON from FCM inAppMessage. type={notificationType}");
            }
#endif

            return json;
        }
        catch (Exception ex)
        {
            Android.Util.Log.Error("MainActivity", $"#####Glitchy_UI##### {source}. exception parsing FCM inAppMessage: {ex}");
            return null;
        }
    }
}