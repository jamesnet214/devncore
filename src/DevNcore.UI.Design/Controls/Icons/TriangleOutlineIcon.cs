using System.Windows;
using DevNcore.UI.Design.Controls.Primitives;

namespace DevNcore.UI.Design.Controls
{
    public class TriangleOutlineIcon : Icon
    {
        static TriangleOutlineIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TriangleOutlineIcon), new FrameworkPropertyMetadata(typeof(TriangleOutlineIcon)));
        }
    }
}
