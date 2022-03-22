using System.Windows;
using DevNcore.UI.Design.Controls.Primitives;

namespace DevNcore.UI.Design.Controls
{
    public class LogoutVariantIcon : Icon
    {
        static LogoutVariantIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LogoutVariantIcon), new FrameworkPropertyMetadata(typeof(LogoutVariantIcon)));
        }
    }
}
