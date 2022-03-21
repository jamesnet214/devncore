using System.Windows;
using DevNcore.UI.Design.Controls.Primitives;

namespace DevNcore.UI.Design.Controls
{
    public class PlayIcon : Icon
    {
        static PlayIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PlayIcon), new FrameworkPropertyMetadata(typeof(PlayIcon)));
        }
    }
}
