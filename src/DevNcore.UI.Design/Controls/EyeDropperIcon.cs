using System.Windows;
using DevNcore.UI.Design.Controls.Primitives;

namespace DevNcore.UI.Design.Controls
{
    public class EyeDropperIcon : Icon
    {
        static EyeDropperIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(EyeDropperIcon), new FrameworkPropertyMetadata(typeof(EyeDropperIcon)));
        }
    }
}
