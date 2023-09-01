using Jamesnet.Wpf.Mvvm;

namespace BlurSharp.Setting.Local.ViewModels
{
    public partial class ProtectContentViewModel : ObservableBase
    {
        private string name;

        public string Name
        {
            get => name;
            set => SetProperty (ref name, value);
        }

        public ProtectContentViewModel()
        {

        }
    }
}
