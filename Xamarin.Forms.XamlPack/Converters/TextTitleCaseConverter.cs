using System;
using System.Globalization;
using System.Threading;

namespace Xamarin.Forms.XamlPack.Converters
{
    public class TextTitleCaseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || !(value is string)) return string.Empty;

            var currentCulture = Thread.CurrentThread.CurrentCulture;

            return currentCulture.TextInfo.ToTitleCase((string)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
