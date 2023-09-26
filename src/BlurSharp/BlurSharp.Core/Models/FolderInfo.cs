using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace BlurSharp.Core.Models
{
    public partial class Folderinfo : FileInfoBase
    {
        [ObservableProperty]
        private bool _isFolderExpanded = true;
        [ObservableProperty]
        private bool _isFolderSelected;

        public ObservableCollection<Folderinfo> Children { get; set; }
    }
}