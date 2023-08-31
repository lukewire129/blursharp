using BlurSharp.Support.UI.Units;
using System.Windows;

namespace BlurSharp.Forms.UI.Views
{
    public class BlurSharpWindow : DarkWindow
    {
        static BlurSharpWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (BlurSharpWindow), new FrameworkPropertyMetadata (typeof (BlurSharpWindow)));
        }
    }
}
