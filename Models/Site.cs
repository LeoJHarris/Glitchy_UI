namespace Glitchy_UI.Models;

[DataContract]
public class Site
{
    [DataMember(Name = "created")]
    public string Created { get; set; } = string.Empty;

    public DateTimeOffset CreatedInternal => DateTimeOffset.Parse(Created);

    [DataMember(Name = "enabled")]
    public bool? Enabled { get; set; }

    [DataMember(Name = "siteAddress")]
    public string SiteAddress { get; set; } = string.Empty;

    [DataMember(Name = "siteID")]
    public long SiteID { get; set; }

    [DataMember(Name = "siteName")]
    public string SiteName { get; set; } = string.Empty;

    [DataMember(Name = "updated")]
    public string? Updated { get; set; }

    public DateTimeOffset? UpdatedInternal => string.IsNullOrEmpty(Updated) ? null : DateTimeOffset.Parse(Updated);
}