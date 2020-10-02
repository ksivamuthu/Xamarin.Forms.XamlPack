using System;
using System.Collections;
using System.Globalization;
using System.Linq;

namespace Xamarin.Forms.XamlPack.Converters
{
    public class IsEmptyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((IEnumerable)value).Cast<object>().Count() == 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
