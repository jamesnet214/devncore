private static void IconTypeChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
{
    var sg = (SingleGeometry)d;
    var data = GeometryPack.Package.GetType().GetField(e.NewValue.ToString()).GetValue(GeometryPack.Package);
    
    sg.SetValue(SingleGeometry.DataProperty, Geometry.parse(data.ToString()));
}
