namespace Glitchy_UI.Models.Converters;

internal sealed class AuditLogActionJsonConverter : JsonConverter<AuditLogAction>
{
    public override AuditLogAction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.String)
        {
            return AuditLogAction.Unknown;
        }

        string? value = reader.GetString();
        if (string.IsNullOrWhiteSpace(value))
        {
            return AuditLogAction.Unknown;
        }

        return value switch
        {
            "loginSuccess" => AuditLogAction.LoginSuccess,
            "loginFailure" => AuditLogAction.LoginFailure,
            "logout" => AuditLogAction.Logout,
            "reauth" => AuditLogAction.Reauth,
            "userAddedToSite" => AuditLogAction.UserAddedToSite,
            "userDeletedFromSite" => AuditLogAction.UserDeletedFromSite,
            "userSiteEnabled" => AuditLogAction.UserSiteEnabled,
            "userSiteDisabled" => AuditLogAction.UserSiteDisabled,
            "userAddedToApp" => AuditLogAction.UserAddedToApp,
            "userAppEnabled" => AuditLogAction.UserAppEnabled,
            "userAppDisabled" => AuditLogAction.UserAppDisabled,
            "userDeletedFromApp" => AuditLogAction.UserDeletedFromApp,
            "userPasswordChanged" => AuditLogAction.UserPasswordChanged,
            "userPermissionChanged" => AuditLogAction.UserPermissionChanged,
            "orgAdminAdded" => AuditLogAction.OrgAdminAdded,
            "orgAdminRemoved" => AuditLogAction.OrgAdminRemoved,
            "accountLocked" => AuditLogAction.AccountLocked,
            "passportDocumentShareAdded" => AuditLogAction.PassportDocumentShareAdded,
            "passportDocumentShareRemoved" => AuditLogAction.PassportDocumentShareRemoved,
            "siteApplicationDeleted" => AuditLogAction.SiteApplicationDeleted,
            "userSiteApplicationDeleted" => AuditLogAction.UserSiteApplicationDeleted,
            _ => AuditLogAction.Unknown
        };
    }

    public override void Write(Utf8JsonWriter writer, AuditLogAction value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value switch
        {
            AuditLogAction.LoginSuccess => "loginSuccess",
            AuditLogAction.LoginFailure => "loginFailure",
            AuditLogAction.Logout => "logout",
            AuditLogAction.Reauth => "reauth",
            AuditLogAction.UserAddedToSite => "userAddedToSite",
            AuditLogAction.UserDeletedFromSite => "userDeletedFromSite",
            AuditLogAction.UserSiteEnabled => "userSiteEnabled",
            AuditLogAction.UserSiteDisabled => "userSiteDisabled",
            AuditLogAction.UserAddedToApp => "userAddedToApp",
            AuditLogAction.UserAppEnabled => "userAppEnabled",
            AuditLogAction.UserAppDisabled => "userAppDisabled",
            AuditLogAction.UserDeletedFromApp => "userDeletedFromApp",
            AuditLogAction.UserPasswordChanged => "userPasswordChanged",
            AuditLogAction.UserPermissionChanged => "userPermissionChanged",
            AuditLogAction.OrgAdminAdded => "orgAdminAdded",
            AuditLogAction.OrgAdminRemoved => "orgAdminRemoved",
            AuditLogAction.AccountLocked => "accountLocked",
            AuditLogAction.PassportDocumentShareAdded => "passportDocumentShareAdded",
            AuditLogAction.PassportDocumentShareRemoved => "passportDocumentShareRemoved",
            AuditLogAction.SiteApplicationDeleted => "siteApplicationDeleted",
            AuditLogAction.UserSiteApplicationDeleted => "userSiteApplicationDeleted",
            _ => "unknown"
        });
    }
}