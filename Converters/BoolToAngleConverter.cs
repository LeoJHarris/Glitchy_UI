namespace Glitchy_UI.Converters;

public sealed class BoolToAngleConverter : IValueConverter
{
    public double CollapsedAngle { get; set; } = 0;
    public double ExpandedAngle { get; set; } = 180;

    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        bool isExpanded = value is true;
        return isExpanded ? ExpandedAngle : CollapsedAngle;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) => throw new NotSupportedException();
}