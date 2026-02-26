namespace Glitchy_UI.Models.ViewModels;

public static class VerificationStatusExtensions
{
    public static string ToDisplayName(this VerificationStatus status)
    {
        return status switch
        {
            VerificationStatus.NotVerified => "Not Verified",
            VerificationStatus.Pending => "Pending Verification",
            VerificationStatus.Verified => "Verified",
            VerificationStatus.Expired => "Expired",
            VerificationStatus.Rejected => "Rejected",
            _ => "Unknown"
        };
    }

    public static string ToIcon(this VerificationStatus status)
    {
        return status switch
        {
            VerificationStatus.NotVerified => "AlertCircleOutline",
            VerificationStatus.Pending => "ClockOutline",
            VerificationStatus.Verified => "CheckCircle",
            VerificationStatus.Expired => "AlertOctagonOutline",
            VerificationStatus.Rejected => "CloseCircleOutline",
            _ => "HelpCircleOutline"
        };
    }

    public static string ToColorResource(this VerificationStatus status)
    {
        return status switch
        {
            VerificationStatus.NotVerified => "Gray500",
            VerificationStatus.Pending => "Warning",
            VerificationStatus.Verified => "Success",
            VerificationStatus.Expired => "Danger",
            VerificationStatus.Rejected => "Danger",
            _ => "Gray500"
        };
    }
}

public static class VisibilitySettingsExtensions
{
    public static string ToDisplayName(this VisibilitySettings settings)
    {
        return settings switch
        {
            VisibilitySettings.Private => "Private",
            VisibilitySettings.ShareWithEmployer => "Shared with Employer",
            VisibilitySettings.ShareWithLocumCompany => "Shared with Locum Company",
            VisibilitySettings.PublicBadge => "Public Badge",
            _ => "Unknown"
        };
    }

    public static string ToIcon(this VisibilitySettings settings)
    {
        return settings switch
        {
            VisibilitySettings.Private => "LockOutline",
            VisibilitySettings.ShareWithEmployer => "AccountOutline",
            VisibilitySettings.ShareWithLocumCompany => "AccountGroupOutline",
            VisibilitySettings.PublicBadge => "EarthOutline",
            _ => "HelpCircleOutline"
        };
    }

    public static string ToDescription(this VisibilitySettings settings)
    {
        return settings switch
        {
            VisibilitySettings.Private => "Only you can view this document",
            VisibilitySettings.ShareWithEmployer => "Your employer can view this document",
            VisibilitySettings.ShareWithLocumCompany => "Locum companies can view this document",
            VisibilitySettings.PublicBadge => "Verification badge visible on your public profile",
            _ => "Unknown visibility setting"
        };
    }
}
