using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BlurSharp.Forms.Local.ViewModels
{
    public partial class BlurSharpWindowViewModel : ObservableBase
    {
        [RelayCommand]
        private void Close(Window window)
        {
            window.Close();
        }
    }
}
