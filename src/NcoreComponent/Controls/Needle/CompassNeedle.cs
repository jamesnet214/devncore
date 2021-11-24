using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NcoreComponent.Controls
{
    public class CompassNeedle1 : Control
    {
        #region DefaultStyleKey

        static CompassNeedle1()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CompassNeedle1), new FrameworkPropertyMetadata(typeof(CompassNeedle1)));
        }
        #endregion
    }
    public class CompassNeedle2 : Control
    {
        static CompassNeedle2()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CompassNeedle2), new FrameworkPropertyMetadata(typeof(CompassNeedle2)));
        }
    }
    public class CompassNeedle3 : Control
    {
        static CompassNeedle3()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CompassNeedle3), new FrameworkPropertyMetadata(typeof(CompassNeedle3)));
        }
    }

    public class CTriangleNeedle : Control
    {
        static CTriangleNeedle()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CTriangleNeedle), new FrameworkPropertyMetadata(typeof(CTriangleNeedle)));
        }
    }
}
