namespace Glitchy_UI.Models;

[DataContract]
public class AuditLog
{
    [DataMember(Name = "action")]
    public AuditLogAction Action { get; set; } = AuditLogAction.Unknown;

    [DataMember(Name = "appID")]
    public long? AppID { get; set; }

    [DataMember(Name = "appName")]
    public string AppName { get; set; } = string.Empty;

    [DataMember(Name = "auditLogID")]
    public long AuditLogID { get; set; }

    [DataMember(Name = "enteredByUserID")]
    public long? EnteredByUserID { get; set; }

    [DataMember(Name = "ipAddress")]
    public string IpAddress { get; set; } = string.Empty;

    [DataMember(Name = "logDate")]
    public string LogDate { get; set; } = string.Empty;

    public DateTimeOffset? LogDateInternal => string.IsNullOrWhiteSpace(LogDate) ? null : DateTimeOffset.Parse(LogDate);

    [DataMember(Name = "siteID")]
    public long? SiteID { get; set; }

    [DataMember(Name = "siteName")]
    public string SiteName { get; set; } = string.Empty;

    [DataMember(Name = "userID")]
    public long? UserID { get; set; }

    [DataMember(Name = "userName")]
    public string UserName { get; set; } = string.Empty;
}