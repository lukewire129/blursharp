using BlurSharp.Core.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BlurSharp.Project.UI.Units
{
    public class FolderTreeItem : TreeViewItem
    {
        static FolderTreeItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (FolderTreeItem), new FrameworkPropertyMetadata (typeof (FolderTreeItem)));
        }

        public FolderTreeItem()
        {
            DefaultStyleKey = typeof (FolderTreeItem);
            DragEnter += Treeview_DragEnter;
            DragLeave += Treeview_DragLeave;
            DragOver += Treeview_DragOver;
        }

        private void Treeview_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent (typeof (FolderTreeItem)))
            {
                e.Effects = DragDropEffects.Move;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void Treeview_DragLeave(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.None;
        }

        private void Treeview_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent (typeof (FolderTreeItem)))
            {
                e.Effects = DragDropEffects.Move;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
        }
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown (e);

            if (e.OriginalSource is FrameworkElement fe)
            {
                if (((Folderinfo)fe.DataContext).IconType == Jamesnet.Wpf.Controls.IconType.Folder)
                    return;
                DragDrop.DoDragDrop (this, fe.DataContext, DragDropEffects.Move);
            }
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new FolderTreeItem ();
        }
    }
}
