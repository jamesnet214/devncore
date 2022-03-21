using System.Windows;
using DevNcore.UI.Design.Controls.Primitives;

namespace DevNcore.UI.Design.Controls
{
    public class MinimizeIcon : Icon
    {
        static MinimizeIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MinimizeIcon), new FrameworkPropertyMetadata(typeof(MinimizeIcon)));
        }
    }
}
