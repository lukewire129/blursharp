using System.Windows;
using System.Windows.Controls;

namespace BlurSharp.Project.UI.Units;

public class SeedTextBox : TextBox
{
    static SeedTextBox()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(SeedTextBox), new FrameworkPropertyMetadata(typeof(SeedTextBox)));
    }
}