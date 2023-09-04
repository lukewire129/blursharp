using BlurSharp.Project.Local.Messenger.EventArgs;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace BlurSharp.Project.Local.Messenger;

public class BaseDirectoryChangeMessage : ValueChangedMessage<FolderDirectory>
{
    public BaseDirectoryChangeMessage(FolderDirectory value) : base(value)
    {
    }
}