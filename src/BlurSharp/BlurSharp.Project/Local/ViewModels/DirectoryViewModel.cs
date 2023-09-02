using BlurSharp.Project.Local.Enums;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
        private string _path;


        [RelayCommand]
        private void Search()
        {
            OpenFileDialog ofd = GetOFD ();
            if (ofd.ShowDialog () == false)
                return;

            Path = ofd.FileName;
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
