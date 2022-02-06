using DevNcore.UI.Design.Controls.Primitives;
using System.Windows;

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
