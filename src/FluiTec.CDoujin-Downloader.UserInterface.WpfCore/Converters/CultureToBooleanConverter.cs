using System;
using System.Globalization;
using System.Windows.Data;

namespace FluiTec.CDoujin_Downloader.UserInterface.WpfCore.Converters
{
    public class CultureToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var given = (CultureInfo)value;
            var result = CultureInfo.CurrentUICulture.Equals(given);
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return CultureInfo.CurrentUICulture;
        }
    }
}
