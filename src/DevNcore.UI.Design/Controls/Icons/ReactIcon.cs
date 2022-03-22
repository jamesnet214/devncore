using System.Windows;
using DevNcore.UI.Design.Controls.Primitives;

namespace DevNcore.UI.Design.Controls
{
    public class ReactIcon : Icon
    {
        static ReactIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ReactIcon), new FrameworkPropertyMetadata(typeof(ReactIcon)));
        }
    }
}
