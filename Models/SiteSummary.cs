namespace Glitchy_UI.Models;

[DataContract]
public class SiteSummary
{
    [DataMember(Name = "orgID")]
    public long OrgID { get; set; }

    [DataMember(Name = "orgName")]
    public string OrgName { get; set; } = string.Empty;

    [DataMember(Name = "siteAddress")]
    public string SiteAddress { get; set; } = string.Empty;

    [DataMember(Name = "siteApplicationCount")]
    public long SiteApplicationCount { get; set; }

    [DataMember(Name = "siteID")]
    public long SiteID { get; set; }

    [DataMember(Name = "siteName")]
    public string SiteName { get; set; } = string.Empty;

    [DataMember(Name = "siteUserCount")]
    public long SiteUserCount { get; set; }
}