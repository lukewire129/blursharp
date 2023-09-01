using BlurSharp.Core.ViewModels;
using BlurSharp.Main.Local.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using Jamesnet.Wpf.Controls;
using Prism.Ioc;
using Prism.Regions;
using System.Collections.ObjectModel;

namespace BlurSharp.Main.Local.ViewModels
{
    public partial class MainContentViewModel : BaseViewModel, IViewLoadable
    {
        [ObservableProperty]
        ObservableCollection<ContentModel> contentModels;
        public MainContentViewModel(IContainerProvider containerProvider,
                                IRegionManager regionManager) :base(containerProvider, regionManager) {
            this.ContentModels = new ()
            {
                new ContentModel ()
                {
                    Name = "PROJECT",
                    Content = this._containerProvider.Resolve<IViewable> ("ProjectContent")
                },
                new ContentModel ()
                {
                    Name = "OPTION",
                    Content = this._containerProvider.Resolve<IViewable> ("SettingContent")
                },
                new ContentModel ()
                {
                    Name = "PROTECT",
                    Content = this._containerProvider.Resolve<IViewable> ("ProtectContent")
                }
            };
        }

        public void OnLoaded(IViewable view)
        {

        }
    }
}
