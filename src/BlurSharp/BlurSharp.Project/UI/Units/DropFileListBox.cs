using System.Windows.Input;
using System.Windows;
using BlurSharp.Core.Local.Models;
using BlurSharp.Core.Models;
using System.IO;
using BlurSharp.Support.UI.Units;

namespace BlurSharp.Project.UI.Units;

public class DropFileListBox : FileListBox
{
    public ICommand AddItemCommand
    {
        get { return (ICommand)GetValue (AddItemCommandProperty); }
        set { SetValue (AddItemCommandProperty, value); }
    }

    // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty AddItemCommandProperty;

    static DropFileListBox()
    {
        AddItemCommandProperty = DependencyProperty.Register ("AddItemCommand", typeof (ICommand), typeof (DropFileListBox), new PropertyMetadata (null));
        DefaultStyleKeyProperty.OverrideMetadata (typeof (DropFileListBox), new FrameworkPropertyMetadata (typeof (DropFileListBox)));
    }

    public DropFileListBox()
    {
        AllowDrop = true;
        Drop += DropFileListBox_Drop;
    }

    private void DropFileListBox_Drop(object sender, DragEventArgs e)
    {
        if (e.Data.GetData (typeof (Folderinfo)) is Folderinfo fi)
        {
            var vm = fi;
            AddItemCommand?.Execute (new FileModel (vm.FullPath, GetRootDirectoryPath (vm))
            {
                IconType = fi.IconType
            });
        }
    }

    private string GetRootDirectoryPath(Folderinfo info)
    {
        string path = info.FullPath;
        for (int i = 0; i <= info.Depth; i++)
        {
            path = Path.GetDirectoryName (path);
        }
        return path;
    }
    protected override DependencyObject GetContainerForItemOverride()
    {
        return new DropFileListItem ();
    }
}
