using System.Windows;
using DevNcore.UI.Design.Controls.Primitives;

namespace DevNcore.UI.Design.Controls
{
    public class AppleIcon : Icon
    {
        static AppleIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AppleIcon), new FrameworkPropertyMetadata(typeof(AppleIcon)));
        }
    }
}
