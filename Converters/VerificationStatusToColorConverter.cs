namespace Glitchy_UI.Converters;

public class VerificationStatusToColorConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is VerificationStatus status)
        {
            return status switch
            {
                VerificationStatus.Verified => Color.FromArgb("#10B981"), // Success green
                VerificationStatus.Pending => Color.FromArgb("#F59E0B"), // Warning orange
                VerificationStatus.Expired => Color.FromArgb("#EF4444"), // Danger red
                VerificationStatus.Rejected => Color.FromArgb("#EF4444"), // Danger red
                VerificationStatus.NotVerified => Color.FromArgb("#6B7280"), // Gray
                _ => Color.FromArgb("#6B7280")
            };
        }

        return Color.FromArgb("#6B7280");
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
