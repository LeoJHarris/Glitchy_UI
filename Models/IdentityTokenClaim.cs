namespace Glitchy_UI.Models;

[DataContract]
public class IdentityTokenClaim
{
    [DataMember]
    public string? ClaimType { get; set; } = string.Empty;

    [DataMember]
    public string? ClaimValue { get; set; } = string.Empty;
}