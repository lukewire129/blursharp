using System.Collections.ObjectModel;
using BlurSharp.Core.ViewModels;
using BlurSharp.Main.Local.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Prism.Ioc;
using Prism.Regions;
using System.Linq;
namespace BlurSharp.Main.Local.ViewModels
{
    public partial class MainContentViewModel : BaseViewModel, IViewLoadable
    {
        [ObservableProperty]
        private ObservableCollection<TabModel> _tabs;
        public MainContentViewModel(IContainerProvider containerProvider,
                                    IRegionManager regionManager) :base(containerProvider, regionManager) {
            this.Tabs = new ObservableCollection<TabModel>()
            {
                new TabModel ()
                {
                    Name = "Project"
                },
                new TabModel ()
                {
                    Name = "Setting"
                },
                new TabModel ()
                {
                    Name = "Protect"
                }
            };
        }

        public void OnLoaded(IViewable view)
        {
            this.Select (this.Tabs.First ());
        }
        
        [RelayCommand]
        private void Select(TabModel tabModel)
        {
            if(this.Tabs.FirstOrDefault (x => x.IsSelected == true) is TabModel item)
            {
                item.IsSelected = false;
            }

            tabModel.IsSelected = true;
            this.ImportContent ("TabRegion", $"{tabModel.Name}Content");
        }
    }
}
