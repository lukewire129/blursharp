using CommunityToolkit.Mvvm.ComponentModel;
using Jamesnet.Wpf.Mvvm;

namespace BlurSharp.Main.Local.Model
{
    public partial class TabModel :ObservableBase
    {
        [ObservableProperty]
        private bool _isSelected = false;
        public string Name { get; set; }
    }
}
