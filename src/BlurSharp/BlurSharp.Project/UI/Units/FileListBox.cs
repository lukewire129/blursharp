using BlurSharp.Core.Local.Models;
using BlurSharp.Core.Models;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BlurSharp.Project.UI.Units;

public class FileListBox : ListBox
{
    public ICommand AddItemCommand
    {
        get { return (ICommand)GetValue (AddItemCommandProperty); }
        set { SetValue (AddItemCommandProperty, value); }
    }

    // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty AddItemCommandProperty =
        DependencyProperty.Register ("AddItemCommand", typeof (ICommand), typeof (FileListBox), new PropertyMetadata (null));


    static FileListBox()
    {
        DefaultStyleKeyProperty.OverrideMetadata (typeof (FileListBox), new FrameworkPropertyMetadata (typeof (FileListBox)));
    }

    public FileListBox()
    {
        AllowDrop = true;
        Drop += FileListBox_Drop;
    }

    private void FileListBox_Drop(object sender, DragEventArgs e)
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
        for (int i=0; i<=info.Depth; i++)
        {
            path = Path.GetDirectoryName (path);
        }
        return path;
    }
    protected override DependencyObject GetContainerForItemOverride()
    {
        return new FileListItem ();
    }
}