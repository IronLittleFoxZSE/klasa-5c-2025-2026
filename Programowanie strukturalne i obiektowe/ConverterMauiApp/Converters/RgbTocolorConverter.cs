using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterMauiApp.Converters
{
    public class RgbToColorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null 
                || values.Length != 3
                || values[0] == null
                || values[1] == null
                || values[2] == null)
                throw new Exception("Błąd");

            int red = (int)(double)values[0];
            int green = (int)(double)values[1];
            int blue = (int)(double)values[2];

            return new Color(red,green, blue);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
