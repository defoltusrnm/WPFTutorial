using System.Windows;

namespace WPFTutorial
{
    public class CustomWindowBase : Window
    {
        public string CustomText
        {
            get => (string)GetValue(CustomTextProperty);
            set => SetValue(CustomTextProperty, value);
        }

        // Используется для создание проп к которым можно биндиться
        public static readonly DependencyProperty CustomTextProperty =
            DependencyProperty.Register(nameof(CustomText), typeof(string), typeof(CustomWindowBase), new PropertyMetadata(""));
    }
}
