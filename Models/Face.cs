namespace Glitchy_UI.Models;

[DataContract]
public class Face
{
    [DataMember(Name = "created")]
    public string Created { get; set; } = string.Empty;

    public DateTimeOffset CreatedInternal => DateTimeOffset.Parse(Created);

    [DataMember(Name = "lastAppId")]
    public long? LastAppId { get; set; }

    [DataMember(Name = "lastIdentify")]
    public string? LastIdentify { get; set; }

    public DateTimeOffset? LastIdentifyInternal => string.IsNullOrEmpty(LastIdentify) ? null : DateTimeOffset.Parse(LastIdentify);

    [DataMember(Name = "lastSiteId")]
    public long? LastSiteId { get; set; }

    [DataMember(Name = "userID")]
    public long UserID { get; set; }
}