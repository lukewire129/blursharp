using BlurSharp.Main.UI.Views;
using BlurSharp.Project.UI.Views;
using BlurSharp.Protect.UI.Views;
using Jamesnet.Wpf.Controls;
using Prism.Ioc;
using Prism.Modularity;

namespace BlurSharp.Properties
{
    internal class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IViewable, MainContent> ("MainContent");
            containerRegistry.RegisterSingleton<IViewable, ProjectContent> ("ProjectContent");
            containerRegistry.RegisterSingleton<IViewable, ProtectContent> ("ProtectContent");
        }
    }
}
