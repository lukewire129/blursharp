using BlurSharp.Forms.UI.Views;
using Jamesnet.Wpf.Controls;
using System.Windows;

namespace BlurSharp
{
    public class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new BlurSharpWindow ();
        }
    }
}
