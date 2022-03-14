using System.Windows;
using DevNcore.UI.Design.Controls.Primitives;

namespace DevNcore.UI.Design.Controls
{
    public class GitHubIcon : Icon
    {
        static GitHubIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GitHubIcon), new FrameworkPropertyMetadata(typeof(GitHubIcon)));
        }
    }
}
