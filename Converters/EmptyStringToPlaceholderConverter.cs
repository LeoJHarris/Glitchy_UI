namespace Glitchy_UI.Converters;

internal sealed class EmptyStringToPlaceholderConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        string? text = value as string;
        string placeholder = parameter as string ?? "N/A";

        return string.IsNullOrWhiteSpace(text) ? placeholder : text;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
