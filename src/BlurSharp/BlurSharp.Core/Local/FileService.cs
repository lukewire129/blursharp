using BlurSharp.Core.Models;
using Jamesnet.Wpf.Controls;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace BlurSharp.Core.Local
{
    public class FileService
    {
        public FileService()
        {

        }

        public void TryRefreshFiles(ObservableCollection<Folderinfo> files, string path)
        {
            files.Clear ();
            var parent = CreateFolderInfo (0, Path.GetDirectoryName (path), IconType.Folder, path);
            parent.Children.AddRange (FetchFilesAndDirectories (path));

            files.Add (parent);
        }

        private Folderinfo CreateFolderInfo(int depth, string name, IconType iconType, string fullPath)
        {
            return new Folderinfo
            {
                Depth = depth,
                Name = name,
                IconType = iconType,
                FullPath = fullPath,
                Children = new ()
            };
        }
        private IEnumerable<Folderinfo> FetchFilesAndDirectories(string path)
        {
            List<string> fileExtensions = new List<string>
        {
            ".exe",
            ".dll"
        };
            return Directory.GetFileSystemEntries (path)
                .Where (file => fileExtensions.Contains (Path.GetExtension (file), StringComparer.OrdinalIgnoreCase))
                .Select (entry => new Folderinfo
                {
                    Name = Path.GetFileName (entry),
                    IconType = Directory.Exists (entry) ? IconType.Folder : DetermineIconType (entry),
                    FullPath = entry,
                    Length = Directory.Exists (entry) ? 0 : new FileInfo (entry).Length,
                })
                .OrderBy (info => info.IconType == IconType.Folder ? 0 : 1)
                .ToList ();
        }

        private IconType DetermineIconType(string file)
        {
            var ext = Path.GetExtension (file).ToUpper ();

            return ext switch
            {
                ".JPG" or ".JPEG" or ".GIF" or ".PNG" => IconType.FileImage,
                ".PDF" => IconType.FilePdf,
                ".ZIP" => IconType.FileZip,
                ".EXE" => IconType.FileCheck,
                ".DOCX" => IconType.FileWord,
                _ => IconType.File
            };
        }
    }
}
