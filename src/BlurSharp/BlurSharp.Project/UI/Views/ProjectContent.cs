using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;

namespace BlurSharp.Project.UI.Views
{
    public class ProjectContent : JamesContent
    {
        static ProjectContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (ProjectContent), new FrameworkPropertyMetadata (typeof (ProjectContent)));
        }
    }
}
