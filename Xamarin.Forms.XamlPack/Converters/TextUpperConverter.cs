using System;
using System.Globalization;

namespace Xamarin.Forms.XamlPack.Converters
{
    public class TextUpperConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || !(value is string)) return string.Empty;

            return ((string)value).ToUpper();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
