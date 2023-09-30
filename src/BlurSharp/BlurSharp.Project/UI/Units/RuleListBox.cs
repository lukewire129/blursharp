using BlurSharp.Support.UI.Units;
using System.Windows;

namespace BlurSharp.Project.UI.Units
{
    public class RuleListBox : FileListBox
    {
        static RuleListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (RuleListBox), new FrameworkPropertyMetadata (typeof (RuleListBox)));
        }
    }
}
