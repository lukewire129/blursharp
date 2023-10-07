using System.Windows;
using System.Windows.Controls;

namespace BlurSharp.Project.UI.Units;

public class DropFileListItem : ListBoxItem
{
    static DropFileListItem()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(DropFileListItem), new FrameworkPropertyMetadata(typeof(DropFileListItem)));
    }
}