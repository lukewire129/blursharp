using System.Windows;
using System.Windows.Controls;

namespace BlurSharp.Support.UI.Units
{
    public class CloseButton : Button
    {
        static CloseButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CloseButton), new FrameworkPropertyMetadata(typeof(CloseButton)));
        }
    }
}
