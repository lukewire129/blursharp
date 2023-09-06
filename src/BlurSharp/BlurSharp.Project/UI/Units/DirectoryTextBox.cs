using System.Windows;
using System.Windows.Controls;

namespace BlurSharp.Project.UI.Units;

public class DirectoryTextBox : ContentControl
{
    static DirectoryTextBox()
    {
        DefaultStyleKeyProperty.OverrideMetadata (typeof (DirectoryTextBox), new FrameworkPropertyMetadata (typeof (DirectoryTextBox)));
    }
}