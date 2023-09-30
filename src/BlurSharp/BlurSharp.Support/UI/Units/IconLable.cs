using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;

namespace BlurSharp.Support.UI.Units
{
    public class IconLable : Button
    {
        public IconType IconType
        {
            get { return (IconType)GetValue (IconTypeProperty); }
            set { SetValue (IconTypeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconTypeProperty =
            DependencyProperty.Register ("IconType", typeof (IconType), typeof (IconLable), new PropertyMetadata (null));

        static IconLable()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (IconLable), new FrameworkPropertyMetadata (typeof (IconLable)));
        }
    }
}
