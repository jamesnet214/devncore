using System.Windows;
using DevNcore.UI.Design.Controls.Primitives;

namespace DevNcore.UI.Design.Controls
{
    public class MicrosoftWindowsClassicIcon : Icon
    {
        static MicrosoftWindowsClassicIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MicrosoftWindowsClassicIcon), new FrameworkPropertyMetadata(typeof(MicrosoftWindowsClassicIcon)));
        }
    }
}
