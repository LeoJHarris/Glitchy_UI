namespace Glitchy_UI;

public static class AppRoutes
{
    private static bool _registered;

    public static void Register()
    {
        if (_registered)
        {
            return;
        }

        _registered = true;

        Routing.RegisterRoute("applicationdetail", typeof(ApplicationDetailPage));
        Routing.RegisterRoute("activityhistorydetail", typeof(AuditLogDetailPage));
        Routing.RegisterRoute("notifications", typeof(NotificationsPage));
        Routing.RegisterRoute("auditlogdetail", typeof(AuditLogDetailPage));
    }
}