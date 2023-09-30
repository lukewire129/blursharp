using Jamesnet.Wpf.Controls;
using System.Windows;

namespace BlurSharp.Project.UI.Views;

public class ProjectContent : JamesContent
{
    static ProjectContent()
    {
        DefaultStyleKeyProperty.OverrideMetadata (typeof (ProjectContent), new FrameworkPropertyMetadata (typeof (ProjectContent)));
    }
}
