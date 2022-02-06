using DevNcore.UI.Design.Controls.Primitives;
using System.Windows;

namespace DevNcore.UI.Design.Controls
{
    public class FileZipIcon : Icon
    {
        static FileZipIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FileZipIcon), new FrameworkPropertyMetadata(typeof(FileZipIcon)));
        }
    }
}
