﻿using System.Windows;
using System.Windows.Controls.Primitives;

namespace BlurSharp.Project.FolderExplorer.UI.Units;

public class ExpandButton : ToggleButton
{
    static ExpandButton()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(ExpandButton), new FrameworkPropertyMetadata(typeof(ExpandButton)));
    }
}
