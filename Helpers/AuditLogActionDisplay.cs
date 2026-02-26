namespace Glitchy_UI.Helpers;

internal static class AuditLogActionDisplay
{
    internal static string ToDisplayName(string? action)
    {
        if (string.IsNullOrWhiteSpace(action))
        {
            return string.Empty;
        }

        return action switch
        {
            "loginSuccess" => "Successful Login",
            "loginFailure" => "Failed Login Attempt",
            "logout" => "User Logout",
            "reauth" => "Re-authentication",
            "userAddedToSite" => "User Added to Site",
            "userDeletedFromSite" => "User Removed from Site",
            "userSiteEnabled" => "Site Access Enabled",
            "userSiteDisabled" => "Site Access Disabled",
            "userAddedToApp" => "Application Access Granted",
            "userAppEnabled" => "Application Enabled",
            "userAppDisabled" => "Application Disabled",
            "userDeletedFromApp" => "Application Access Revoked",
            "userPasswordChanged" => "Password Changed",
            "userPermissionChanged" => "Permissions Modified",
            "orgAdminAdded" => "Organization Admin Added",
            "orgAdminRemoved" => "Organization Admin Removed",
            "siteApplicationDeleted" => "Site Application Deleted",
            "userSiteApplicationDeleted" => "User Application Removed from Site",
            _ => action
        };
    }
}