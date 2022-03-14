using System.Windows;
using DevNcore.UI.Design.Controls.Primitives;

namespace DevNcore.UI.Design.Controls
{
    public class HistoryIcon : Icon
    {
        static HistoryIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HistoryIcon), new FrameworkPropertyMetadata(typeof(HistoryIcon)));
        }
    }
}
