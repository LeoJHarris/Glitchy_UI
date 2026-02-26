namespace Glitchy_UI.Types;

public enum ReauthStatus
{
    [EnumMember(Value = "pending")]
    [Display(Name = "Pending")]
    Pending,

    [EnumMember(Value = "completed")]
    [Display(Name = "Completed")]
    Completed,

    [EnumMember(Value = "expired")]
    [Display(Name = "Expired")]
    Expired
}