using System.Windows;
using System.Windows.Controls;

namespace BlurSharp.Project.UI.Units;

public class FileListBox : ListBox
{
    static FileListBox()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(FileListBox), new FrameworkPropertyMetadata(typeof(FileListBox)));;
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new FileListItem();
    }
}