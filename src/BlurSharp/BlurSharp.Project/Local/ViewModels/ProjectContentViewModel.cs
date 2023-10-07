using BlurSharp.Core.Local.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using System.Collections.ObjectModel;

namespace BlurSharp.Project.Local.ViewModels;

public partial class ProjectContentViewModel :ObservableBase, IViewLoadable
{
    [ObservableProperty] ObservableCollection<FileModel> _obfuscationFiles;
    public ProjectContentViewModel()
    {
        this.ObfuscationFiles = new ();
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
    void AddItem(FileModel fileModel)
    {
        this.ObfuscationFiles.Add (fileModel);
    }
}