using BlurSharp.Core.Local.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using Jamesnet.Wpf.Mvvm;
using System.Collections.ObjectModel;

namespace BlurSharp.Setting.Local.ViewModels
{
    public partial class SettingContentViewModel : ObservableBase
    {
        [ObservableProperty] private ObservableCollection<FileModel> fileModels;
        public SettingContentViewModel()
        {

        }
    }
}
