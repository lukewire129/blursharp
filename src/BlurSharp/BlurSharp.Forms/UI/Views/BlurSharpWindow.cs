using Jamesnet.Wpf.Controls;
using System.Windows;

namespace BlurSharp.Forms.UI.Views
{
    public class BlurSharpWindow : DarkThemeWindow
    {
        static BlurSharpWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (BlurSharpWindow), new FrameworkPropertyMetadata (typeof (BlurSharpWindow)));
        }
    }
}
