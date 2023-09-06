using System.Windows;
using System.Windows.Controls;

namespace BlurSharp.Project.UI.Units;

public class SedTextBox :TextBox
{
    static SedTextBox()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(SedTextBox), new FrameworkPropertyMetadata(typeof(SedTextBox)));
    }
}