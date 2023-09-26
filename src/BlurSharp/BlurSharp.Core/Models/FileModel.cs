using CommunityToolkit.Mvvm.ComponentModel;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using System.Reflection;

namespace BlurSharp.Core.Local.Models;

public partial class FileModel : ObservableBase 
{
    public IconType IconType { get; set; }
    [ObservableProperty] private string _simpleName;
    [ObservableProperty] private string _assemblyName;
    [ObservableProperty] private string _relativePathFile;
    private readonly string _fullPath;
    public FileModel(string fullPath, string rootPath)
    {
        this._fullPath = fullPath;
        try
        {

            RelativePathFile = Confuser.Core.Utils.GetRelativePath(this._fullPath, rootPath) ?? this._fullPath;
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
