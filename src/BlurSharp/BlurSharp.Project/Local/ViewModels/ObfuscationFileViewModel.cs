using System.Collections.ObjectModel;
using BlurSharp.Project.Local.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Mvvm;

namespace BlurSharp.Project.Local.ViewModels;

public partial class ObfuscationFileViewModel : ObservableBase
{
    [ObservableProperty] 
    private ObservableCollection<FileModel> _obfuscationFiles;
    public ObfuscationFileViewModel()
    {
        this.ObfuscationFiles = new();
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