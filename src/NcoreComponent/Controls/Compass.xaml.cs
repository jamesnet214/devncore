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
    /// <summary>
    /// Compass.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Compass : UserControl
    {
        #region Variables

        /// <summary>
        /// 캔버스 중앙 X좌표
        /// </summary>
        double cx;
        /// <summary>
        /// 캔버스 중앙 Y좌표
        /// </summary>
        double cy;
        // 가장 바깥
        double label_R;
        double gauge_R;
        double large_R;
        const int degreeOffset = 270;
        #endregion

        public Compass()
        {
            InitializeComponent();
            SetScale();
        }

        private void SetScale()
        {
            cx = canvas.Width / 2;
            cy = canvas.Height / 2;
            label_R = cx;
            gauge_R = label_R * 0.9;
            large_R = gauge_R * 0.8;

            // 360번 for 문
            int gaugeDegree = 360;

            // Thickness 테두리
            for (int i = 0; i < gaugeDegree; i++)
            {
                double cos = (double)Math.Cos(DegreesToRadians(i + degreeOffset));
                double sin = (double)Math.Sin(DegreesToRadians(i + degreeOffset));

                double x1 = cx + gauge_R * cos;
                double y1 = cy + gauge_R * sin;

                double x2 = cx + large_R * cos;
                double y2 = cx + large_R * sin;

                Line line = new Line();
                line.SetResourceReference(Shape.StrokeProperty, "Compas.Back");
                line.StrokeThickness = 0.5;

                line.X1 = x1;
                line.X2 = x2;
                line.Y1 = y1;
                line.Y2 = y2;
                canvas.Children.Add(line);
            }
        }

        #region DegreesToRadians: 각도 계산

        private double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }
        #endregion
    }
}
