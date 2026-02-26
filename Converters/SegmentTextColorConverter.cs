namespace Glitchy_UI.Converters;

public class SegmentTextColorConverter : IValueConverter
{
    static Color GetColor(string resourceKey, Color fallback)
    {
        if (Application.Current?.Resources is not null &&
            Application.Current.Resources.TryGetValue(resourceKey, out var value) &&
            value is Color color)
        {
            return color;
        }

        return fallback;
    }

    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is bool isSelected)
        {
            return isSelected
                ? GetColor("White", Colors.White)
                : GetColor("Gray600", Color.FromArgb("#404040"));
        }

        return GetColor("Gray600", Color.FromArgb("#404040"));
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
