namespace Glitchy_UI.Models;

public enum AuditLogAction
{
    [Display(Name = "Successful Login")]
    LoginSuccess,

    [Display(Name = "Failed Login Attempt")]
    LoginFailure,

    [Display(Name = "User Logout")]
    Logout,

    [Display(Name = "Re-authentication")]
    Reauth,

    [Display(Name = "User Added to Site")]
    UserAddedToSite,

    [Display(Name = "User Removed from Site")]
    UserDeletedFromSite,

    [Display(Name = "Site Access Enabled")]
    UserSiteEnabled,

    [Display(Name = "Site Access Disabled")]
    UserSiteDisabled,

    [Display(Name = "Application Access Granted")]
    UserAddedToApp,

    [Display(Name = "Application Enabled")]
    UserAppEnabled,

    [Display(Name = "Application Disabled")]
    UserAppDisabled,

    [Display(Name = "Application Access Revoked")]
    UserDeletedFromApp,

    [Display(Name = "Password Changed")]
    UserPasswordChanged,

    [Display(Name = "Permissions Modified")]
    UserPermissionChanged,

    [Display(Name = "Organization Admin Added")]
    OrgAdminAdded,

    [Display(Name = "Organization Admin Removed")]
    OrgAdminRemoved,

    [Display(Name = "Account Locked")]
    AccountLocked,

    [Display(Name = "Document Share Added")]
    PassportDocumentShareAdded,

    [Display(Name = "Document Share Removed")]
    PassportDocumentShareRemoved,

    [Display(Name = "Site Application Deleted")]
    SiteApplicationDeleted,

    [Display(Name = "User Application Removed from Site")]
    UserSiteApplicationDeleted,

    [Display(Name = "Unknown")]
    Unknown
}