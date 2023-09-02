using BlurSharp.Project.Local.Enums;
using BlurSharp.Project.Local.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using System.Collections.ObjectModel;

namespace BlurSharp.Project.Local.ViewModels
{
    public partial class ProjectContentViewModel :ObservableBase, IViewLoadable
    {
        public DirectoryViewModel Base { get; set; }
        public DirectoryViewModel Output { get; set; }

        [ObservableProperty]
        private ObservableCollection<FileModel> _obfuserFiles;

        public ProjectContentViewModel()
        {
            this.Base = new (DirectoryType.BASE);
            this.Output = new (DirectoryType.OUTPUT);
            this.ObfuserFiles = new ();
        }

        public void OnLoaded(IViewable view)
        {
            this.Load ();    
        }

        // TODO : Solution Open 시 업로드
        public void Load()
        {

        }

        [RelayCommand]
        private void AddFile()
        {

        }

        [RelayCommand]
        private void DelFile()
        {

        }
    }
}