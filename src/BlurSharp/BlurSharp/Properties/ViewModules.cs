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
            //containerRegistry.RegisterSingleton<IViewable, MainContent> ("MainContent");
            //containerRegistry.RegisterSingleton<IViewable, LocationContent> ("LocationContent");
        }
    }
}
