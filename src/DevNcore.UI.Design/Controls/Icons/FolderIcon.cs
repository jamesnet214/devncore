using System.Windows;
using DevNcore.UI.Design.Controls.Primitives;

namespace DevNcore.UI.Design.Controls
{
    public class FolderIcon : Icon
    {
        static FolderIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FolderIcon), new FrameworkPropertyMetadata(typeof(FolderIcon)));
        }
    }
}
