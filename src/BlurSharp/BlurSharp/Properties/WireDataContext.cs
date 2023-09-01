using BlurSharp.Forms.Local.ViewModels;
using BlurSharp.Forms.UI.Views;
using BlurSharp.Main.Local.ViewModels;
using BlurSharp.Main.UI.Views;
using BlurSharp.Setting.Local.ViewModels;
using Jamesnet.Wpf.Global.Location;

namespace BlurSharp.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<BlurSharpWindow, BlurSharpWindowViewModel> ();
            items.Register<MainContent, MainContentViewModel> ();
            items.Register<SettingContent, SettingContentViewModel> ();
            items.Register<ProtectContent, ProtectContentViewModel> ();
        }
    }
}
