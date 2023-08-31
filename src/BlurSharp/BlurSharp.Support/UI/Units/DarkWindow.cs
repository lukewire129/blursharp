using Jamesnet.Wpf.Controls;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BlurSharp.Support.UI.Units
{
    public class DarkWindow : JamesWindow
    {
        public static readonly DependencyProperty CloseCommandProperty = 
            DependencyProperty.Register("CloseCommand", typeof(ICommand), typeof(DarkWindow), new PropertyMetadata(null));
        public static readonly DependencyProperty TitleTemplateProperty = 
            DependencyProperty.Register("TitleTemplate", typeof(DataTemplate), typeof(DarkWindow), new PropertyMetadata(null));
        public static readonly new DependencyProperty TitleProperty = 
            DependencyProperty.Register("Title", typeof(object), typeof(DarkWindow), new UIPropertyMetadata(null));

        public DataTemplate TitleTemplate
        {
            get { return (DataTemplate)GetValue(TitleTemplateProperty); }
            set { SetValue(TitleTemplateProperty, value); }
        }

        public new object Title
        {
            get => GetValue(TitleTemplateProperty);
            set => SetValue(TitleTemplateProperty, value);
        }

        public ICommand CloseCommand
        {
            get => (ICommand)GetValue(CloseCommandProperty);
            set => SetValue(CloseCommandProperty, value);
        }

        static DarkWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DarkWindow), new FrameworkPropertyMetadata(typeof(DarkWindow)));
        }

        public override void OnApplyTemplate()
        {
            if (GetTemplateChild("PART_CloseButton") is Button btn)
            {
                btn.Click += (s, e) => WindowClose();
            }
            if (GetTemplateChild("PART_MinButton") is Button minbtn)
            {
                minbtn.Click += (s, e) => WindowState = WindowState.Minimized;
            }
            //if (GetTemplateChild ("PART_MaxButton") is MaximizeButton maxbtn)
            //{
            //    maxbtn.Click += (s, e) =>
            //    {
            //        if (maxbtn.Maximize)
            //        {
            //            this.WindowState = WindowState.Normal;
            //            maxbtn.Maximize = !maxbtn.Maximize;
            //            return;
            //        }
            //        this.WindowState = WindowState.Maximized;
            //        maxbtn.Maximize = !maxbtn.Maximize;
            //    };
            //}
            if (GetTemplateChild("PART_DragBar") is DraggableBar bar)
            {
                bar.MouseDown += WindowDragMove;
            }
        }

        private void WindowClose()
        {
            if (CloseCommand == null)
            {
                Close();
            }
            else
            {
                CloseCommand.Execute(this);
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

        private void WindowDragMove(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                GetWindow(this).DragMove();
            }
        }
    }
}
