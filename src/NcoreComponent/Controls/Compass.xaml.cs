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
    public partial class Compass : UserControl
    {
        #region Variables

        double cx;
        double cy;
        double label_R;
        double bigCircle_R;
        double outCircle_R;
        double tiny_R;
        double inCircle_R;
        const int degreeOffset = 270;
        const int primaryTick = 45;
        const int SecondTick = 3;
        private CTriangleNeedle needle4;
        #endregion

        public Compass()
        {
            InitializeComponent();
            SetScale();

            Triangle();
        }


        private void Triangle()
        {
            needle4 = new CTriangleNeedle();
            canvas.Children.Add(needle4);
            needle4.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
            Canvas.SetLeft(needle4, cx - (needle4.DesiredSize.Width / 2 ));
        }
        
        #region 콤파스

        private void SetScale()
        {
            cx = canvas.Width / 2;
            cy = canvas.Height / 2;
            label_R = cx;
            bigCircle_R = label_R * 1;
            outCircle_R = label_R * 0.85;
            tiny_R = outCircle_R * 0.85;
            inCircle_R = outCircle_R * 0.75;

            int gaugeDegree = 360;
            for (int i = 0; i < gaugeDegree; i++)
            {
                double cos = (double)Math.Cos(DegreesToRadians(i + degreeOffset));
                double sin = (double)Math.Sin(DegreesToRadians(i + degreeOffset));
                double x1 = cx + outCircle_R * cos;
                double y1 = cy + outCircle_R * sin;
                double x2 = cx + inCircle_R * cos;
                double y2 = cy + inCircle_R * sin;

                Line line = new Line();
                line.SetResourceReference(Shape.StrokeProperty, "Compas.Back");
                line.StrokeThickness = 3;

                line.X1 = x1;
                line.X2 = x2;
                line.Y1 = y1;
                line.Y2 = y2;

                canvas.Children.Add(line);
            }

            for (int i = 0; i < 360; i += SecondTick)
            {
                double cos = (double)Math.Cos(DegreesToRadians(i + degreeOffset));
                double sin = (double)Math.Sin(DegreesToRadians(i + degreeOffset));
                double x1 = cx + inCircle_R * cos;
                double y1 = cy + inCircle_R * sin;
                double x2 = 0;
                double y2 = 0;

                if (i % primaryTick == 0)
                {
                    // 45도
                    x2 = cx + outCircle_R * cos;
                    y2 = cy + outCircle_R * sin;
                    double x3 = cx + bigCircle_R * cos;
                    double y3 = cy + bigCircle_R * sin;

                    Label label = new Label();
                    label.Content = $"{(DirectionType)i}";
                    label.SetResourceReference(ForegroundProperty, "Compas.Label");
                    label.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
                    Size s = label.DesiredSize;
                    Canvas.SetLeft(label, x3 - (s.Width / 2));
                    Canvas.SetTop(label, y3 - (s.Height / 2));

                    canvas.Children.Add(label);
                }
                else
                {
                    // 3도
                    x2 = cx + tiny_R * cos;
                    y2 = cy + tiny_R * sin;
                }

                Line line = new Line();
                line.SetResourceReference(Shape.StrokeProperty, "Compas.Mark");
                line.StrokeThickness = 1;

                line.X1 = x1;
                line.X2 = x2;
                line.Y1 = y1;
                line.Y2 = y2;

                canvas.Children.Add(line);
            }
        }
        #endregion

        #region DegreesToRadians: 각도 계산

        private double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }
        #endregion
    }
}
