using System.Windows;
using DevNcore.UI.Design.Controls.Primitives;

namespace DevNcore.UI.Design.Controls
{
    public class AlphaBBoxIcon : Icon
    {
        static AlphaBBoxIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AlphaBBoxIcon), new FrameworkPropertyMetadata(typeof(AlphaBBoxIcon)));
        }
    }
}
