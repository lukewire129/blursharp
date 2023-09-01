using Jamesnet.Wpf.Controls;
using System.Windows;

namespace BlurSharp.Setting.UI.Views
{
    public class SettingContent : JamesContent
    {
        static SettingContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SettingContent), new FrameworkPropertyMetadata(typeof(SettingContent)));
        }
    }
}
