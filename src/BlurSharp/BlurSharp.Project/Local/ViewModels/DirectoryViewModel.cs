using System.IO;
using BlurSharp.Project.Local.Enums;
using BlurSharp.Project.Local.Messenger;
using BlurSharp.Project.Local.Messenger.EventArgs;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Win32;

namespace BlurSharp.Project.Local.ViewModels
{
    public partial class DirectoryViewModel : ObservableObject
    {
        private DirectoryType Type { get; }

        public DirectoryViewModel(DirectoryType type)
        {
            this.Type = type;
            if (this.Type == DirectoryType.OUTPUT)
                return;
            
            WeakReferenceMessenger.Default.Register<DirectoryViewModel, BaseDirectoryRequestMessage>(this, (r, m) =>
            {
                // Assume that "CurrentUser" is a private member in our viewmodel.
                // As before, we're accessing it through the recipient passed as
                // input to the handler, to avoid capturing "this" in the delegate.
                m.Reply(r.GetMessageType());
            });
        }
        [ObservableProperty] private string _pathDirectory;
        [RelayCommand]
        private void Search()
        {
            OpenFileDialog ofd = OpenFileDialogOption();
            if (ofd.ShowDialog() == false)
                return;

            if (IsPathDirectoryNotice(ofd.FileName))
                return;

            WeakReferenceMessenger.Default.Send(GetMessageType());
        }

        private OpenFileDialog OpenFileDialogOption() => new()
        {
            Multiselect = false
        };

        private FolderDirectory GetMessageType() => new FolderDirectory()
        {
            DirectoryPath = this.PathDirectory
        };
        private bool IsPathDirectoryNotice(string fileNames)
        {
            this.PathDirectory = Path.GetDirectoryName(fileNames);
            if (this.PathDirectory == null)
                return false;

            if (this.Type == DirectoryType.OUTPUT)
                return false;

            return true;
        }
    }
}