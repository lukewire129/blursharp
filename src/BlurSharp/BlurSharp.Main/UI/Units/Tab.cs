using System.Windows;
using System.Windows.Controls;

namespace BlurSharp.Main.UI.Units
{
    public class Tab : ListBox
    {
        static Tab()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (Tab), new FrameworkPropertyMetadata (typeof (Tab)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new TabItem ();
        }
    }
}
