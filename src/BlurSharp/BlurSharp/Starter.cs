using BlurSharp.Properties;
using System;

namespace BlurSharp
{
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            _ = new App ()
                .AddInversionModule<HelperModules> ()
                .AddInversionModule<ViewModules> ()
                .AddWireDataContext<WireDataContext> ()
                .Run ();
        }
    }
}
