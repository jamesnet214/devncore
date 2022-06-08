using DevNcore.UI.Design.Geometry;
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
        private static void IconTypeChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var sg = (SingleGeometry)d;
            var data = GeometryPack.Instance.GetType().GetField(e.NewValue.ToString()).GetValue(GeometryPack.Instance);

            sg.SetValue(SingleGeometry.DataProperty, System.Windows.Media.Geometry.Parse(data.ToString()));
        }

    }

}
