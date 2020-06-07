using System;
using System.Globalization;
using Xamarin.Forms;

namespace AirMonitor.Util.Converter
{
    public class PercentConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!double.TryParse(value?.ToString(), out var result))
            {
                return value;
            }
            return $"{result}%";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var newValue = value.ToString().Replace("%", "");
            if (!int.TryParse(newValue, out var result))
            {
                return result;
            }
            return 0;
        }
    }
}