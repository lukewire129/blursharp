using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;

namespace BlurSharp.Core.ViewModels
{
    public class BaseViewModel : ObservableBase
    {
        protected readonly IContainerProvider _containerProvider;
        protected readonly IRegionManager _regionManager;

        public BaseViewModel(IContainerProvider containerProvider,
                             IRegionManager regionManager)
        {
            this._containerProvider = containerProvider;
            this._regionManager = regionManager;
        }

        protected void ImportContent(string regionName, string contentName)
        {
            IRegion region = _regionManager.Regions[regionName];
            IViewable content = _containerProvider.Resolve<IViewable> (contentName);

            if (!region.Views.Contains (content))
            {
                region.Add (content);
            }
            region.Activate (content);
        }
    }
}
