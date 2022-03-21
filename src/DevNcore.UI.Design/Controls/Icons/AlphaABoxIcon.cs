using System.Windows;
using DevNcore.UI.Design.Controls.Primitives;

namespace DevNcore.UI.Design.Controls
{
    public class AlphaABoxIcon : Icon
    {
        static AlphaABoxIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AlphaABoxIcon), new FrameworkPropertyMetadata(typeof(AlphaABoxIcon)));
        }
    }
}
