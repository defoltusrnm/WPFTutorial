using System;
using System.Globalization;
using System.Windows.Data;

namespace WPFTutorial.Converters
{
    public abstract class ValueConverter<TIn, TOut> : IValueConverter
    {
        public abstract TOut Convert(TIn value, CultureInfo cultureInfo);

        public abstract TIn ConvertBack(TOut value, CultureInfo cultureInfo);

        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Convert((TIn)value, culture) ?? Binding.DoNothing;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ConvertBack((TOut)value, culture) ?? Binding.DoNothing;
        }
    }
}
