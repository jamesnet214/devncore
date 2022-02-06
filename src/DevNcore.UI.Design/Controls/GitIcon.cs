using DevNcore.UI.Design.Controls.Primitives;
using System.Windows;

namespace DevNcore.UI.Design.Controls
{
    public class GitIcon : Icon
    {
        static GitIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GitIcon), new FrameworkPropertyMetadata(typeof(GitIcon)));
        }
    }
}
