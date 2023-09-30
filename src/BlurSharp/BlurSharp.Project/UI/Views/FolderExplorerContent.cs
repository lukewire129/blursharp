using Jamesnet.Wpf.Controls;
using System.Windows;

namespace BlurSharp.Project.UI.Views;

public class FolderExplorerContent : JamesContent
{
    static FolderExplorerContent()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(FolderExplorerContent), new FrameworkPropertyMetadata(typeof(FolderExplorerContent)));
    }
}
