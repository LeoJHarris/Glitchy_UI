namespace Glitchy_UI.Models;

[DataContract]
public class SiteUserListItem
{
    [DataMember(Name = "accessEndDate")]
    public string? AccessEndDate { get; set; }

    public DateTimeOffset? AccessEndDateInternal => string.IsNullOrEmpty(AccessEndDate) ? null : DateTimeOffset.Parse(AccessEndDate);

    [DataMember(Name = "accessStartDate")]
    public string? AccessStartDate { get; set; }

    public DateTimeOffset? AccessStartDateInternal => string.IsNullOrEmpty(AccessStartDate) ? null : DateTimeOffset.Parse(AccessStartDate);

    [DataMember(Name = "created")]
    public string Created { get; set; } = string.Empty;

    [DataMember(Name = "createdByUserID")]
    public long CreatedByUserID { get; set; }

    public DateTimeOffset CreatedInternal => DateTimeOffset.Parse(Created);

    [DataMember(Name = "enabled")]
    public bool? Enabled { get; set; }

    [DataMember(Name = "permission")]
    public SitePermission Permission { get; set; }

    [DataMember(Name = "updated")]
    public string? Updated { get; set; }

    [DataMember(Name = "updatedByEmail")]
    public string? UpdatedByEmail { get; set; }

    [DataMember(Name = "updatedByName")]
    public string? UpdatedByName { get; set; }

    [DataMember(Name = "updatedByUserId")]
    public long? UpdatedByUserId { get; set; }

    public DateTimeOffset? UpdatedInternal => string.IsNullOrEmpty(Updated) ? null : DateTimeOffset.Parse(Updated);

    [DataMember(Name = "userEmail")]
    public string? UserEmail { get; set; }

    [DataMember(Name = "userID")]
    public long UserID { get; set; }

    [DataMember(Name = "userName")]
    public string? UserName { get; set; }
}