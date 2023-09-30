using System.Windows;
using System.Windows.Controls;

namespace BlurSharp.Project.UI.Units
{
    public class RuleListBox : ListBox
    {
        static RuleListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (RuleListBox), new FrameworkPropertyMetadata (typeof (RuleListBox)));
        }
    }
}
