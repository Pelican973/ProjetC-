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
    /// Convert pour multibinding
    /// </summary>
    public class AngleMultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            //on receptionne des milliseconde:
            double Multiple = 1.0;
            double res = 0.0;

            try
            {
                double v = (double)values[0];
                bool reverse = (bool)values[1];                


                switch ((string)parameter)
                {
                    case "MilliSeconde":
                        Multiple = 1.0;
                        res = (double)(v * 0.36);
                        break;
                    case "Seconde":
                        Multiple = 6.0;
                        res = (double)(v % (60d * 1000d) / 1000d);
                        break;
                    case "Minute":
                        Multiple = 6.0;
                        res = (v % (60d * 60d * 1000d)) / (60d * 1000d);
                        break;
                    case "Heure":
                        Multiple = 6.0;
                        res = ((v % (12d * 60d * 60d * 1000d))) / (12d * 60d * 1000d);
                        break;
                    default:
                        break;
                }
                return (reverse ? -1 : 1) * (res * Multiple);
            }
            catch { return null; }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
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
