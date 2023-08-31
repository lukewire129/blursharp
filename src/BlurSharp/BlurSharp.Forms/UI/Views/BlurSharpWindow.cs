using DarkSkinWindow.UI.Views;
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
