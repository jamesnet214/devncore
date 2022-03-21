using System.Windows;
using DevNcore.UI.Design.Controls.Primitives;

namespace DevNcore.UI.Design.Controls
{
    public class CircleOutlineIcon : Icon
    {
        static CircleOutlineIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CircleOutlineIcon), new FrameworkPropertyMetadata(typeof(CircleOutlineIcon)));
        }
    }
}
