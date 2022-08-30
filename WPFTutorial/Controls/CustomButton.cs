using System.Diagnostics;
using System.Windows.Controls;

namespace WPFTutorial.Controls
{
    /// <summary>
    /// Есть возможность расширять контролы без создание пользовательских
    /// </summary>
    public class CustomButton : Button
    {
        protected override void OnClick()
        {
            Debug.WriteLine("Clicked");
            base.OnClick();
        }
    }
}
