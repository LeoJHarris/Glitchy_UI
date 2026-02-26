namespace Glitchy_UI.Models;

[DataContract]
public class MFA
{
    [DataMember(Name = "appId")]
    public long? AppId { get; set; }

    [DataMember(Name = "appName")]
    public string? AppName { get; set; } = string.Empty;

    [DataMember(Name = "created")]
    public string Created { get; set; } = string.Empty;

    public DateTimeOffset CreatedInternal => DateTimeOffset.Parse(Created);

    [DataMember(Name = "externalId")]
    public string? ExternalId { get; set; }

    [DataMember(Name = "ipAddress")]
    public string IpAddress { get; set; } = string.Empty;

    [DataMember(Name = "lastResend")]
    public string LastResend { get; set; } = string.Empty;

    public DateTimeOffset? LastResendInternal => string.IsNullOrEmpty(LastResend) ? null : DateTimeOffset.Parse(LastResend);

    [DataMember(Name = "location")]
    public string Location { get; set; } = string.Empty;

    [DataMember(Name = "mfaCode")]
    public string? MfaCode { get; set; } = string.Empty;

    [DataMember(Name = "mfaid")]
    public long MfaId { get; set; }

    [DataMember(Name = "mfaType")]
    public MFAType MfaType { get; set; }

    [DataMember(Name = "resend")]
    public bool Resend { get; set; }

    [DataMember(Name = "resendCount")]
    public long ResendCount { get; set; }

    [DataMember(Name = "siteID")]
    public long? SiteID { get; set; }

    [DataMember(Name = "siteName")]
    public string SiteName { get; set; } = string.Empty;

    [DataMember(Name = "status")]
    public MFAStatus Status { get; set; }

    [DataMember(Name = "updated")]
    public string? Updated { get; set; } = string.Empty;

    public DateTimeOffset? UpdatedInternal => string.IsNullOrEmpty(Updated) ? null : DateTimeOffset.Parse(Updated);

    [DataMember(Name = "userID")]
    public long UserID { get; set; }
}