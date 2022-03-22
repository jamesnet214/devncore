using System.Windows;
using DevNcore.UI.Design.Controls.Primitives;

namespace DevNcore.UI.Design.Controls
{
    public class EmailSendIcon : Icon
    {
        static EmailSendIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(EmailSendIcon), new FrameworkPropertyMetadata(typeof(EmailSendIcon)));
        }
    }
}
