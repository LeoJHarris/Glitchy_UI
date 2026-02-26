namespace Glitchy_UI.Models;

[DataContract]
public class DevicePush
{
    public DevicePush()
    {
    }

    public DevicePush(string pnsHandle, string pnsType)
    {
        PnsHandle = pnsHandle;
        PnsType = pnsType;
    }

    [DataMember(Name = "installationId")]
    public string? InstallationId { get; set; } = string.Empty;

    [DataMember(Name = "pnsHandle")]
    public string PnsHandle { get; set; } = string.Empty;

    [DataMember(Name = "pnsType")]
    public string PnsType { get; set; } = string.Empty;

    [DataMember(Name = "userID")]
    public long UserID { get; set; }
}