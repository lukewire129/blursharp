using BlurSharp.Core.Local;
using BlurSharp.Core.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Mvvm;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Collections.ObjectModel;

namespace BlurSharp.Project.FolderExplorer.Local.ViewModels;

public partial class FolderExplorerViewModel : ObservableBase
{
    private readonly FileService _fileService;
    [ObservableProperty] ObservableCollection<Folderinfo> _files;
    public FolderExplorerViewModel(FileService fileService)
    {
        this.Files = new ();
        this._fileService = fileService;
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
