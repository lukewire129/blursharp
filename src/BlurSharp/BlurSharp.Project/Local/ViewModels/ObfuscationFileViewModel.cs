using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using BlurSharp.Project.Local.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Mvvm;
using Microsoft.Win32;

namespace BlurSharp.Project.Local.ViewModels;

public partial class ObfuscationFileViewModel : ObservableBase
{
    [ObservableProperty] 
    private ObservableCollection<FileModel> _obfuscationFiles;
   
    public ObfuscationFileViewModel()
    {
        this.ObfuscationFiles = new();
    }
    
    [RelayCommand(CanExecute = nameof(CanAddFile))]
    private void AddFile(string baseDirectory)
    {
        var ofd = this.GetOpenFileDialogSet();

        var ret = ofd.ShowDialog() ?? false;
        if (ret == false)
            return;
        foreach (var file in ofd.FileNames)
            AddModule(file);
    }
    private bool CanAddFile(string baseDirectory)
    {
        return !String.IsNullOrWhiteSpace(baseDirectory);
    }

    [RelayCommand(CanExecute = nameof(CanDelFile))]
    private void DelFile(FileModel fileModel)
    {

    }
    private bool CanDelFile(FileModel fileModel)
    {
        return fileModel is not null;
    }
    void AddModule(string file) {
        if (!File.Exists(file)) {
            MessageBox.Show(string.Format("File '{0}' does not exists!", file), "ConfuserEx", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        var moduleFile = new FileModel(file);
        this.ObfuscationFiles.Add(moduleFile);
    }
    private OpenFileDialog GetOpenFileDialogSet() => new OpenFileDialog()
    {
        Filter = ".NET assemblies (*.exe, *.dll)|*.exe;*.dll|All Files (*.*)|*.*",
        Multiselect = true
    };
}