namespace Glitchy_UI.Models;

[DataContract]
public class Application
{
    public DateTimeOffset? AccessEndDate => string.IsNullOrWhiteSpace(AccessEndDateStr) ? null : DateTimeOffset.Parse(AccessEndDateStr);

    [DataMember(Name = "accessEndDate")]
    public string? AccessEndDateStr { get; set; }

    public DateTimeOffset? AccessStartDate => string.IsNullOrWhiteSpace(AccessStartDateStr) ? null : DateTimeOffset.Parse(AccessStartDateStr);

    [DataMember(Name = "accessStartDate")]
    public string? AccessStartDateStr { get; set; }

    [DataMember(Name = "applicationID")]
    public long ApplicationID { get; set; }

    [DataMember(Name = "applicationLogo")]
    public string? ApplicationLogo { get; set; } = string.Empty;

    [DataMember(Name = "applicationName")]
    public string ApplicationName { get; set; } = string.Empty;

    [DataMember(Name = "applicationVendor")]
    public string ApplicationVendor { get; set; } = string.Empty;

    [DataMember(Name = "applicationVendorLogo")]
    public string? ApplicationVendorLogo { get; set; } = string.Empty;

    [DataMember(Name = "created")]
    public string Created { get; set; } = string.Empty;

    public DateTimeOffset? CreatedInternal => string.IsNullOrWhiteSpace(Created) ? null : DateTimeOffset.TryParse(Created, out DateTimeOffset result) ? result : null;

    [DataMember(Name = "enabled")]
    public bool Enabled { get; set; }

    [DataMember(Name = "siteId")]
    public long SiteId { get; set; }
}