using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace value_converters
{
    class ColorPltoColorEnConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if(targetType != typeof(Brush))
            {
                throw new InvalidOperationException("Celem powinien być typ Brush!");
            }
            string kolorPL = value.ToString();
            Dictionary<string, Brush> kolory = new Dictionary<string, Brush>();

            kolory.Add("Czarny", Brushes.Black);
            kolory.Add("Czerwony", Brushes.Red);
            kolory.Add("Żółty", Brushes.Yellow);
            kolory.Add("Zielony", Brushes.Green);
            kolory.Add("Niebieski", Brushes.Blue);

            if (kolory.ContainsKey(kolorPL))
                return kolory[kolorPL];
            else
                return Brushes.LightGray;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
