namespace Glitchy_UI.DataTemplateSelectors;

public class NotificationDataTemplateSelector : DataTemplateSelector
{
    public DataTemplate? MFADataTemplate { get; set; }

    public DataTemplate? ReauthDataTemplate { get; set; }

    public DataTemplate? SiteRequestDataTemplate { get; set; }

    protected override DataTemplate? OnSelectTemplate(object item, BindableObject container)
    {
        if (item is LocalNotificationViewModel notificationViewModel)
        {
            return notificationViewModel.NotificationType switch
            {
                NotificationType.MfaRequest => MFADataTemplate,
                NotificationType.ReauthRequest => ReauthDataTemplate,
                NotificationType.MfaSiteRequest => SiteRequestDataTemplate,
                _ => null
            };
        }

        return null;
    }
}