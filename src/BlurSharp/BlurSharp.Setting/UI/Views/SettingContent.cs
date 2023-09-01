using Jamesnet.Wpf.Controls;
using System.Windows;

namespace BlurSharp.Main.UI.Views
{
    public class SettingContent : JamesContent
    {
        static SettingContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SettingContent), new FrameworkPropertyMetadata(typeof(SettingContent)));
        }
    }
}
