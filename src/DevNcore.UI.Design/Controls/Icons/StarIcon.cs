using System.Windows;
using DevNcore.UI.Design.Controls.Primitives;

namespace DevNcore.UI.Design.Controls
{
    public class StarIcon : Icon
    {
        static StarIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StarIcon), new FrameworkPropertyMetadata(typeof(StarIcon)));
        }
    }
}
