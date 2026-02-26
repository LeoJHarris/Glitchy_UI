namespace Glitchy_UI.Models;

[DataContract]
public class ReauthExtendedInfo
{
    [DataMember(Name = "applicationLogo")]
    public string? ApplicationLogo { get; set; }

    [DataMember(Name = "applicationName")]
    public string? ApplicationName { get; set; }

    [DataMember(Name = "siteName")]
    public string? SiteName { get; set; }
}