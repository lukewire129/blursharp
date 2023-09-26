using BlurSharp.Core.Local;
using BlurSharp.Core.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Collections.ObjectModel;

namespace BlurSharp.Project.Local.ViewModels
{
    public partial class ProjectContentViewModel :ObservableBase, IViewLoadable
    {
        private readonly FileService _fileService;

        public ObfuscationFileViewModel ObfuscationFile { get; set; }

        [ObservableProperty] private ObservableCollection<Folderinfo> _files;
        public ProjectContentViewModel(FileService fileService)
        {
            this.ObfuscationFile = new();

            this.Files = new ();
            this._fileService = fileService;
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
        private void OpenDialog()
        {
            var ofd = this.GetOpenFileDialogSet ();

            if (ofd.ShowDialog () != CommonFileDialogResult.Ok)
                return;
            this._fileService.TryRefreshFiles (this.Files, ofd.FileName);
        }
        private CommonOpenFileDialog GetOpenFileDialogSet() => new CommonOpenFileDialog ()
        {
            IsFolderPicker = true
        };
    }
}