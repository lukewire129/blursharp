using BlurSharp.Forms.Local.ViewModels;
using BlurSharp.Forms.UI.Views;
using BlurSharp.Main.Local.ViewModels;
using BlurSharp.Main.UI.Views;
using BlurSharp.Project.Local.ViewModels;
using BlurSharp.Project.UI.Views;
using BlurSharp.Protect.UI.Views;
using BlurSharp.Setting.Local.ViewModels;
using BlurSharp.Setting.UI.Views;
using Jamesnet.Wpf.Global.Location;

namespace BlurSharp.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<BlurSharpWindow, BlurSharpWindowViewModel> ();
            items.Register<MainContent, MainContentViewModel> ();
            items.Register<ProjectContent, ProjectContentViewModel> ();
            items.Register<SettingContent, SettingContentViewModel> ();
            items.Register<ProtectContent, ProtectContentViewModel> ();
        }
    }
}
