using System.Windows;
using System.Windows.Controls;

namespace BlurSharp.Support.UI.Units
{
    public class MaximizeButton : Button
    {
        static MaximizeButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MaximizeButton), new FrameworkPropertyMetadata(typeof(MaximizeButton)));
        }
    }
}
