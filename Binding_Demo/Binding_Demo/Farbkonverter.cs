using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Binding_Demo
{
    public class Farbkonverter : IValueConverter // Schnittstelle für Konverter
    {
        // OneWay-Binding
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (string.IsNullOrWhiteSpace(value.ToString()))
                return Brushes.Black;

            string wert = (string)value;
            if (wert == "Rot")
                return Brushes.Red;
            else if (wert == "Gelb")
                return Brushes.Yellow;
            else
                return Brushes.Blue;

          //var x = new SolidColorBrush(Color.FromRgb(10, 50, 100))
        }

        // TwoWay-Binding
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
