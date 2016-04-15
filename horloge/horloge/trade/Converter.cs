using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace horloge.trade
{
    /// <summary>
    /// Permet de convertir des secondes en angle 
    /// </summary>
    public class DateAngleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double angle = 0;
            
            if (parameter != null)
            {
                string param = parameter.ToString();
                switch (param)
                {
                    case "SEC":
                        angle = (double)value *0.006;
                        break;
                    case "MIN":
                        angle = (double)value * 0.0001;
                        break;
                    case "HOUR":
                        angle = (double)value * 30 / 3600000;
                        break;
                }
            }

            return angle;
        }

        public object ConvertBack(object value, Type targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
