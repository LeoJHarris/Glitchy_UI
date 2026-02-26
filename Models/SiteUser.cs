namespace Glitchy_UI.Models;

[DataContract]
public class SiteUser
{
    [DataMember(Name = "created")]
    public DateTime Created { get; set; }

    [DataMember(Name = "createdByUserID")]
    public long CreatedByUserID { get; set; }

    [DataMember(Name = "enabled")]
    public bool Enabled { get; set; }

    [DataMember(Name = "siteID")]
    public long SiteID { get; set; }

    [DataMember(Name = "updated")]
    public DateTime Updated { get; set; }

    [DataMember(Name = "updatedByUserID")]
    public long UpdatedByUserID { get; set; }

    [DataMember(Name = "userID")]
    public long UserID { get; set; }
}