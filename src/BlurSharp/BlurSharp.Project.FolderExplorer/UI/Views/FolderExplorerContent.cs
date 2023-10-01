using Jamesnet.Wpf.Controls;
using System.Windows;

namespace BlurSharp.Project.FolderExplorer.UI.Views;

public enum ViewReactive
{
    BASE,
    COMPACT
}
public class FolderExplorerContent : JamesContent
{
    public ViewReactive ContentReactive
    {
        get { return (ViewReactive)GetValue (ContentReactiveProperty); }
        set { SetValue (ContentReactiveProperty, value); }
    }

    public static readonly DependencyProperty ContentReactiveProperty;

    static FolderExplorerContent()
    {
        ContentReactiveProperty = DependencyProperty.Register ("ContentReactive", typeof (ViewReactive), typeof (FolderExplorerContent), new PropertyMetadata (null));
        DefaultStyleKeyProperty.OverrideMetadata (typeof (FolderExplorerContent), new FrameworkPropertyMetadata (typeof (FolderExplorerContent)));
    }
    public FolderExplorerContent()
    {
        SizeChanged += FolderExplorerContent_SizeChanged;
    }

    private void FolderExplorerContent_SizeChanged(object sender, SizeChangedEventArgs e)
    {
        if (e.WidthChanged == false)
            return;
       
        if (this.ActualWidth > 70.0)
        {
            ContentReactive = ViewReactive.BASE;
            return;
        }
        ContentReactive = ViewReactive.COMPACT;
    }
}
