using System.Windows;
using DevNcore.UI.Design.Controls.Primitives;

namespace DevNcore.UI.Design.Controls
{
    public class CheckBoldIcon : Icon
    {
        static CheckBoldIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CheckBoldIcon), new FrameworkPropertyMetadata(typeof(CheckBoldIcon)));
        }
    }
}
