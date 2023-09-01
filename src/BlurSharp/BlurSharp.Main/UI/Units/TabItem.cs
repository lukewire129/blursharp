using BlurSharp.Main.Local.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BlurSharp.Main.UI.Units
{
    public class TabItem : Button
    {
        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectCommandProperty =
            DependencyProperty.Register ("SelectCommand", typeof (ICommand), typeof (TabItem), new PropertyMetadata (null));

        public ICommand SelectCommand
        {
            get { return (ICommand)GetValue (SelectCommandProperty); }
            set { SetValue (SelectCommandProperty, value); }
        }


        static TabItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (TabItem), new FrameworkPropertyMetadata (typeof (TabItem)));
        }

        public TabItem()
        {
            this.Click += (s, e) =>
            {
                this.SelectCommand?.Execute (this.DataContext);
            };
        }
    }
}
