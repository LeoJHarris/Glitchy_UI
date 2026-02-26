namespace Glitchy_UI.Models;

[DataContract]
public class User
{
    [DataMember(Name = "Id")]
    public long Id { get; set; }

    [DataMember(Name = "Name")]
    public string Name { get; set; } = string.Empty;
}