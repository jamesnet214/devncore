using System.Windows;
using DevNcore.UI.Design.Controls.Primitives;
namespace DevNcore.UI.Design.Controls
{
    public class FileIcon : Icon
    {
        static FileIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FileIcon), new FrameworkPropertyMetadata(typeof(FileIcon)));
        }
    }
}
