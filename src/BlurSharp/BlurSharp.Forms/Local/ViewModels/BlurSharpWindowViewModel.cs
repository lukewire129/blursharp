using BlurSharp.Core.ViewModels;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Prism.Ioc;
using Prism.Regions;
using System.Windows;

namespace BlurSharp.Forms.Local.ViewModels
{
    public partial class BlurSharpWindowViewModel : BaseViewModel, IViewLoadable
    {
        public BlurSharpWindowViewModel(IContainerProvider containerProvider,
                                        IRegionManager regionManager)
            : base (containerProvider, regionManager) { }

        public void OnLoaded(IViewable view)
        {
            this.ImportContent ("MainRegion", "MainContent");
        }

        [RelayCommand]
        private void Close(Window window)
        {
            window.Close ();
        }
    }
}
