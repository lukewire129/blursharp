using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Controls;

namespace BlurSharp.Project.UI.Units
{
    public class ExplorerComponent : ContentControl
    {
        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue (MyPropertyProperty); }
            set { SetValue (MyPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty;


        static ExplorerComponent()
        {
            MyPropertyProperty = DependencyProperty.Register ("MyProperty", typeof (IEnumerable), typeof (ExplorerComponent), new PropertyMetadata (null));
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExplorerComponent), new FrameworkPropertyMetadata(typeof (ExplorerComponent)));
        }
    }
}
