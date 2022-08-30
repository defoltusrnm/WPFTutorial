using System;

namespace WPFTutorial
{
    /// <summary>
    /// Кастомная точка входа в приложение
    /// </summary>
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            App app = new();
            app.InitializeComponent();
            app.Run();
        }
    }
}
