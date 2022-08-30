using System.Collections.ObjectModel;
using System.Globalization;

namespace WPFTutorial.Converters
{
    public class StringCollectionToStringConverter : ValueConverter<ObservableCollection<string>, string>
    {
        public string Separator { get; set; } = "\n";

        public override string Convert(ObservableCollection<string> value, CultureInfo cultureInfo)
        {
            return string.Join(Separator, value);
        }

        public override ObservableCollection<string> ConvertBack(string value, CultureInfo cultureInfo)
        {
            if (value is not string text)
            {
                return null!;
            }

            return new ObservableCollection<string>(text.Split(Separator));
        }
    }
}
