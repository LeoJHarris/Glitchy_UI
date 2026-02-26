namespace Glitchy_UI.Models;

[DataContract]
public class Reauth
{
    [DataMember(Name = "appId")]
    public long? AppId { get; set; }

    [DataMember(Name = "created")]
    public string Created { get; set; } = string.Empty;

    [DataMember(Name = "createdByUserId")]
    public long? CreatedByUserId { get; set; }

    public DateTimeOffset CreatedInternal => DateTimeOffset.Parse(Created);

    [DataMember(Name = "expires")]
    public string? Expires { get; set; }

    public DateTimeOffset? ExpiresInternal => string.IsNullOrEmpty(Expires) ? null : DateTimeOffset.Parse(Expires);

    [DataMember(Name = "extendedInfo")]
    public ReauthExtendedInfo? ExtendedInfo { get; set; }

    [DataMember(Name = "externalReference")]
    public string ExternalReference { get; set; } = string.Empty;

    [DataMember(Name = "reauthId")]
    public long ReauthId { get; set; }

    [DataMember(Name = "siteId")]
    public long? SiteId { get; set; }

    [DataMember(Name = "status")]
    public ReauthStatus Status { get; set; }

    [DataMember(Name = "userID")]
    public long UserID { get; set; }
}