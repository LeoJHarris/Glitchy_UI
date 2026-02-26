namespace Glitchy_UI.Helpers;

internal static class EnumDisplayName
{
    internal static string Get(Enum value)
    {
        MemberInfo? member = value.GetType().GetMember(value.ToString()).FirstOrDefault();
        DisplayAttribute? display = member?.GetCustomAttribute<DisplayAttribute>();
        return display?.GetName() ?? value.ToString();
    }
}