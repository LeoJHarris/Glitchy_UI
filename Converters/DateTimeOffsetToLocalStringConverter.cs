namespace Glitchy_UI.Converters;

public class DateTimeOffsetToLocalStringConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not DateTimeOffset dateTimeOffset)
        {
            return null;
        }

        DateTime localDateTime = dateTimeOffset.LocalDateTime;

        // Use the parameter as the format string if provided
        if (parameter is string format && !string.IsNullOrWhiteSpace(format))
        {
            return localDateTime.ToString(format, culture);
        }

        // Default format
        return localDateTime.ToString("MMM dd, yyyy", culture);
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}