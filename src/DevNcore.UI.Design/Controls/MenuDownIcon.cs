using DevNcore.UI.Design.Controls.Primitives;
using System.Windows;

namespace DevNcore.UI.Design.Controls
{
    public class MenuDownIcon : Icon
    {
        static MenuDownIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MenuDownIcon), new FrameworkPropertyMetadata(typeof(MenuDownIcon)));
        }
    }
}
