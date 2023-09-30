using System.Windows;
using System.Windows.Controls;

namespace BlurSharp.Support.UI.Units;

public class FileListBox : ListBox
{
    static FileListBox()
    {
        DefaultStyleKeyProperty.OverrideMetadata (typeof (FileListBox), new FrameworkPropertyMetadata (typeof (FileListBox)));
    }
}