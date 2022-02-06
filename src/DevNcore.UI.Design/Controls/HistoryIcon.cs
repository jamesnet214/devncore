using DevNcore.UI.Design.Controls.Primitives;
using System.Windows;

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
