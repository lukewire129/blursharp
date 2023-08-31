using Jamesnet.Wpf.Global.Location;

namespace BlurSharp.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            //items.Register<LocationContent, LocationContentViewModel> ();
            //items.Register<MainContent, MainContentViewModel> ();
            //items.Register<ExplorerWindow, ExplorerViewModel> ();
        }
    }
}
