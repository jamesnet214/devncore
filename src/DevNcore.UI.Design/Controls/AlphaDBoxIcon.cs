using System.Windows;
using DevNcore.UI.Design.Controls.Primitives;

namespace DevNcore.UI.Design.Controls
{
    public class AlphaDBoxIcon : Icon
    {
        static AlphaDBoxIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AlphaDBoxIcon), new FrameworkPropertyMetadata(typeof(AlphaDBoxIcon)));
        }
    }
}
