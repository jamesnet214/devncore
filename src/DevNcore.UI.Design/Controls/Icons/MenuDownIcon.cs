using System.Windows;
using DevNcore.UI.Design.Controls.Primitives;

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
