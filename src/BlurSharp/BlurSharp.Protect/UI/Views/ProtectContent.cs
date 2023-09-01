using Jamesnet.Wpf.Controls;
using System.Windows;

namespace BlurSharp.Main.UI.Views
{
    public class ProtectContent : JamesContent
    {
        static ProtectContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ProtectContent), new FrameworkPropertyMetadata(typeof(ProtectContent)));
        }
    }
}
