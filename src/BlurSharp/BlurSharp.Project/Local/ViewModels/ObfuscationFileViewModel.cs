using BlurSharp.Core.Local.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Mvvm;
using System.Collections.ObjectModel;

namespace BlurSharp.Project.Local.ViewModels;

public partial class ObfuscationFileViewModel : ObservableBase
{
    [ObservableProperty] 
    private ObservableCollection<FileModel> _obfuscationFiles;
   
    public ObfuscationFileViewModel()
    {
        this.ObfuscationFiles = new();
    }
    public void AddModule(FileModel moduleFile) {
        this.ObfuscationFiles.Add(moduleFile);
    }

    [RelayCommand]
    private void AddItem(FileModel fileModel)
    {
        this.AddModule (fileModel);
    }
}