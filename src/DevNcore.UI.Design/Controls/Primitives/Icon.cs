using DevNcore.WPF.Controls;
using System.Windows;

namespace DevNcore.UI.Design.Controls.Primitives
{
    public class Icon : DevNcoreIcon
    {
        static Icon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Icon), new FrameworkPropertyMetadata(typeof(Icon)));
        }
    }
}
