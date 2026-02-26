namespace Glitchy_UI.Models;

[DataContract]
public class SiteApplication
{
    [DataMember(Name = "applicationId")]
    public long ApplicationId { get; set; }

    [DataMember(Name = "applicationLogo")]
    public string? ApplicationLogo { get; set; }

    [DataMember(Name = "applicationName")]
    public string ApplicationName { get; set; } = string.Empty;

    [DataMember(Name = "connectedByEmail")]
    public string? ConnectedByEmail { get; set; }

    [DataMember(Name = "connectedByName")]
    public string? ConnectedByName { get; set; }

    [DataMember(Name = "connectedByUserID")]
    public long? ConnectedByUserID { get; set; }

    [DataMember(Name = "connectedDate")]
    public string? ConnectedDate { get; set; }

    public DateTimeOffset? ConnectedDateInternal => string.IsNullOrEmpty(ConnectedDate) ? null : DateTimeOffset.Parse(ConnectedDate);

    [DataMember(Name = "created")]
    public string Created { get; set; } = string.Empty;

    [DataMember(Name = "createdByEmail")]
    public string? CreatedByEmail { get; set; }

    [DataMember(Name = "createdByName")]
    public string? CreatedByName { get; set; }

    [DataMember(Name = "createdByUserId")]
    public long CreatedByUserId { get; set; }

    public DateTimeOffset CreatedInternal => DateTimeOffset.Parse(Created);

    [DataMember(Name = "siteId")]
    public long SiteId { get; set; }

    [DataMember(Name = "tenantID")]
    public string? TenantID { get; set; }

    [DataMember(Name = "vendorLogo")]
    public string? VendorLogo { get; set; }

    [DataMember(Name = "vendorName")]
    public string? VendorName { get; set; }
}