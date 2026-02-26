namespace Glitchy_UI.Converters;

/// <summary>
/// Multi-value converter that compares two values for equality and returns corresponding objects.
/// Usage: Pass 4 values - [0] = first value to compare, [1] = second value to compare, [2] = return if equal (TrueObject), [3] = return if not equal (FalseObject)
/// </summary>
public class EqualityConverter : IMultiValueConverter
{
    public object? Convert(object?[]? values, Type targetType, object? parameter, CultureInfo culture)
    {
        if (values == null || values.Length < 4)
        {
            return values?[3]; // Return FalseObject as default
        }

        // Compare values[0] and values[1]
        bool areEqual = Equals(values[0], values[1]);

        // Return values[2] (TrueObject) if equal, values[3] (FalseObject) if not
        return areEqual ? values[2] : values[3];
    }

    public object?[]? ConvertBack(object? value, Type[] targetTypes, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
