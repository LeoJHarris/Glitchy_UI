namespace Glitchy_UI.Models;

[DataContract]
public class UserRegistration
{
    [DataMember(Name = "email")]
    public string Email { get; set; } = string.Empty;

    [DataMember(Name = "firstName")]
    public string FirstName { get; set; } = string.Empty;

    [DataMember(Name = "lastName")]
    public string LastName { get; set; } = string.Empty;

    [DataMember(Name = "mobilePhoneNumber")]
    public string MobilePhoneNumber { get; set; } = string.Empty;

    [DataMember(Name = "passwordStr")]
    public string Password { get; set; } = string.Empty;
}