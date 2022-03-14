using System.Windows;
using DevNcore.UI.Design.Controls.Primitives;

namespace DevNcore.UI.Design.Controls
{
    public class MenuRightIcon : Icon
    {
        static MenuRightIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MenuRightIcon), new FrameworkPropertyMetadata(typeof(MenuRightIcon)));
        }
    }
}
