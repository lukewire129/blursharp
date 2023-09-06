using BlurSharp.Project.Local.Enums;
using BlurSharp.Project.Local.Messenger.EventArgs;
using CommunityToolkit.Mvvm.Messaging;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;

namespace BlurSharp.Project.Local.ViewModels
{
    public partial class ProjectContentViewModel :ObservableBase, IViewLoadable
    {
        public DirectoryViewModel Base { get; set; }
        public DirectoryViewModel Output { get; set; }
        public ObfuscationFileViewModel ObfuscationFile { get; set; }
        public ProjectContentViewModel()
        {
            this.Base = new (DirectoryType.BASE);
            this.Output = new (DirectoryType.OUTPUT);
            this.ObfuscationFile = new();
            
            WeakReferenceMessenger.Default.Register<FolderDirectory>(this, (r, data) =>
            {
                Output.PathDirectory = $"{data.DirectoryPath}\\Confuser";
            });
        }

        public void OnLoaded(IViewable view)
        {
            this.Load ();    
        }

        // TODO : Solution Open 시 업로드
        public void Load()
        {

        }
    }
}