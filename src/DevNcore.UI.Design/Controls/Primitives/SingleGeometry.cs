using DevNcore.WPF.Controls;
using System.Windows;

namespace DevNcore.UI.Design.Controls.Primitives
{
    public class SingleGeometry : DevNcorePath
    {
        static SingleGeometry()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Icon), new FrameworkPropertyMetadata(typeof(Icon)));
        }
    }
}
