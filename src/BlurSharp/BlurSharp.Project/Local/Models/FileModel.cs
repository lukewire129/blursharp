using System;
using System.Reflection;
using System.Threading;
using BlurSharp.Project.Local.Messenger;
using BlurSharp.Project.Local.Messenger.EventArgs;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Jamesnet.Wpf.Mvvm;

namespace BlurSharp.Project.Local.Models;

public partial class FileModel : ObservableBase 
{   
    [ObservableProperty] private string _simpleName;
    [ObservableProperty] private string _assemblyName;
    [ObservableProperty] private string _relativePathFile;
    private readonly string _fullPath;
    
    public FileModel(string fullPath)
    {
        this._fullPath = fullPath;
        try
        {
            FolderDirectory directory = WeakReferenceMessenger.Default.Send<BaseDirectoryRequestMessage>();
            RelativePathFile = Confuser.Core.Utils.GetRelativePath(this._fullPath, directory.DirectoryPath) ?? this._fullPath;
        }
        catch 
        {
            RelativePathFile = this._fullPath;
        }
        SimpleName = System.IO.Path.GetFileName( this._fullPath);
        this.LoadAssemblyName();
    }
    
    void LoadAssemblyName() {
        AssemblyName = "Loading...";
        ThreadPool.QueueUserWorkItem(_ => {
            try {
                AssemblyName name = System.Reflection.AssemblyName.GetAssemblyName(this._fullPath);
                AssemblyName = name.FullName;
            }
            catch {
                AssemblyName = "Unknown";
            }
        });
    }
}
