namespace Glitchy_UI.Converters;

public class BoolToEnabledTextConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is bool enabled)
        {
            return enabled ? "Active" : "Disabled";
        }

        return "Unknown";
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}