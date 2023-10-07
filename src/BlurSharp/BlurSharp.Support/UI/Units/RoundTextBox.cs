using System.Windows;
using System.Windows.Controls;

namespace BlurSharp.Project.UI.Units;

public class RoundTextBox : TextBox
{
    static RoundTextBox()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(RoundTextBox), new FrameworkPropertyMetadata(typeof(RoundTextBox)));
    }
}