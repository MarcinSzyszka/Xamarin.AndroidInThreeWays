using System;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace AndroidMVVM.Droid.Infrastructure
{
    public class StringToIntConverter :  MvxValueConverter<int?, string>
    {
        protected override string Convert(int? value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.HasValue)
            {
                return value.ToString();
            }

            return "0";
        }

        protected override int? ConvertBack(string value, Type targetType, object parameter, CultureInfo culture)
        {
            int intValue;

            if (!string.IsNullOrEmpty(value) && int.TryParse(value, out intValue))
            {
                return intValue;
            }

            return 0;
        }
    }
}