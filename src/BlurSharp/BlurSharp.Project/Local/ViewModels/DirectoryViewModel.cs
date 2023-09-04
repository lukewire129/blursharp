using System;
using System.Diagnostics;
using System.Windows;
using BlurSharp.Project.Local.Enums;
using BlurSharp.Project.Local.Messenger.EventArgs;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Win32;

namespace BlurSharp.Project.Local.ViewModels
{
    public partial class DirectoryViewModel : ObservableObject
    {
        public DirectoryType Type { get; }
        public DirectoryViewModel(DirectoryType type)
        {
            this.Type = type;
        }

        [ObservableProperty]
        private string _pathDirectory;


        [RelayCommand]
        private void Search()
        {
            OpenFileDialog ofd = GetOFD ();
            if (ofd.ShowDialog () == false)
                return;
            
            PathDirectory = System.IO.Path.GetDirectoryName(ofd.FileName);

            if (Type == DirectoryType.BASE)
            {
                WeakReferenceMessenger.Default.Send(new FolderDirectory()
                {
                    DirectoryPath = this.PathDirectory
                });
            }
        }


        private OpenFileDialog GetOFD()
        {
            return new OpenFileDialog ()
            {
                Multiselect = false
            };
        }
    }
}
