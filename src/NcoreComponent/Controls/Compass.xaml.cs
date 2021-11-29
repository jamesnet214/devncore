using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NcoreComponent.Controls
{
    public partial class Compass : UserControl
    {
        #region DValue1

        public static readonly DependencyProperty DValue1Property = DependencyProperty.Register(
       "DValue1", typeof(double), typeof(Compass), new PropertyMetadata(0.0, OnDValueChangedCallBack));

        public double DValue1
        {
            get { return (double)GetValue(DValue1Property); }
            set { SetValue(DValue1Property, value); }
        }
        #endregion

        #region DValue2

        public static readonly DependencyProperty DValue2Property = DependencyProperty.Register(
       "DValue2", typeof(double), typeof(Compass), new PropertyMetadata(0.0, OnDValueChangedCallBack));

        public double DValue2
        {
            get { return (double)GetValue(DValue2Property); }
            set { SetValue(DValue2Property, value); }
        }
        #endregion

        #region DValue3

        public static readonly DependencyProperty DValue3Property = DependencyProperty.Register(
       "DValue3", typeof(double), typeof(Compass), new PropertyMetadata(0.0, OnDValueChangedCallBack));

        public double DValue3
        {
            get { return (double)GetValue(DValue3Property); }
            set { SetValue(DValue3Property, value); }
        }
        #endregion

        #region DValue4

        public static readonly DependencyProperty DValue4Property = DependencyProperty.Register(
       "DValue4", typeof(double), typeof(Compass), new PropertyMetadata(0.0, OnDValueChangedCallBack));

        public double DValue4
        {
            get { return (double)GetValue(DValue4Property); }
            set { SetValue(DValue4Property, value); }
        }
        #endregion

        #region Variables

        double angle1;
        double angle2;
        double angle3;
        double angle4;
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
        private CompassNeedle1 compassNeedle1;
        private CompassNeedle2 compassNeedle2;
        private CompassNeedle3 compassNeedle3;
        private CTriangleNeedle needle4;
        #endregion

        #region Constructor

        public Compass()
        {
            InitializeComponent();

            Thread thread = new Thread(() =>
            {
                while(true)
                {                
                    RandomCount();

                    Thread.Sleep(3000);
                    
                    this.Dispatcher.Invoke(() =>
                    {
                        RotateTransform rt = new RotateTransform(angle1, needle4.ActualWidth / 2, needle4.ActualHeight + inCircle_R);
                        DoubleAnimation a = new DoubleAnimation(angle1, angle1 = RandomCount(), new TimeSpan(0, 0, 0, 3));
                        needle4.RenderTransform = rt;
                        rt.BeginAnimation(RotateTransform.AngleProperty, a);

                        RotateTransform rt2 = new RotateTransform(angle2, compassNeedle1.ActualWidth / 2, compassNeedle1.ActualHeight);
                        DoubleAnimation a2 = new DoubleAnimation(angle2, angle2 = RandomCount(), new TimeSpan(0, 0, 0, 3));
                        compassNeedle1.RenderTransform = rt2;
                        rt2.BeginAnimation(RotateTransform.AngleProperty, a2);

                        RotateTransform rt3 = new RotateTransform(angle3, compassNeedle2.ActualWidth / 2, compassNeedle2.ActualHeight);
                        DoubleAnimation a3 = new DoubleAnimation(angle3, angle3 = RandomCount(), new TimeSpan(0, 0, 0, 3));
                        compassNeedle2.RenderTransform = rt3;
                        rt3.BeginAnimation(RotateTransform.AngleProperty, a3);

                        RotateTransform rt4 = new RotateTransform(angle4, compassNeedle3.ActualWidth / 2, compassNeedle3.ActualHeight / 2);
                        DoubleAnimation a4 = new DoubleAnimation(angle4, angle4 = RandomCount(), new TimeSpan(0, 0, 0, 3));
                        compassNeedle3.RenderTransform = rt4;
                        rt4.BeginAnimation(RotateTransform.AngleProperty, a4);


                    });
                }
            });
            thread.Start();
            thread.IsBackground = true;

            SetScale();
            Needle3();
            Needle1();
            Needle2();
            Triangle();
        }

        private double RandomCount()
        {
            double result = new Random().Next(0, 361);

            return result;
        }
        #endregion

        #region Needles

        private void Needle1()
        {
            compassNeedle1 = new CompassNeedle1();
            canvas.Children.Add(compassNeedle1);
            compassNeedle1.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));

            Canvas.SetLeft(compassNeedle1, cx - compassNeedle1.DesiredSize.Width / 2);
            Canvas.SetTop(compassNeedle1, cy - compassNeedle1.DesiredSize.Height);
        }

        private void Needle2()
        {
            compassNeedle2 = new CompassNeedle2();
            canvas.Children.Add(compassNeedle2);
            compassNeedle2.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));

            Canvas.SetLeft(compassNeedle2, cx - compassNeedle2.DesiredSize.Width / 2);
            Canvas.SetTop(compassNeedle2, cy - compassNeedle2.DesiredSize.Height);
        }

        private void Needle3()
        {
            compassNeedle3 = new CompassNeedle3();
            canvas.Children.Add(compassNeedle3);
            compassNeedle3.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));

            Canvas.SetLeft(compassNeedle3, cx - compassNeedle3.DesiredSize.Width / 2 );
            Canvas.SetTop(compassNeedle3, cy - compassNeedle3.DesiredSize.Height / 2);
        }

        private void Triangle()
        {
            needle4 = new CTriangleNeedle();
            canvas.Children.Add(needle4);
            needle4.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
            Canvas.SetLeft(needle4, cx - (needle4.DesiredSize.Width / 2 ));
            Canvas.SetTop(needle4, cy - inCircle_R - needle4.DesiredSize.Height);
        }
        #endregion

        #region DVvalueChanged

        private static void OnDValueChangedCallBack(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            Compass c = sender as Compass;
            var propertyName = e.Property.Name;

            double value = 0;
            if (e.NewValue != null)
                value = (double)e.NewValue;


            c.ValueChanged(value, propertyName);
        }

        private void ValueChanged(double value, string propertyName)
        {
            switch (propertyName)
            {
                case "DValue1":
                    SetAnimation(value, compassNeedle1);
                    break;
                case "DValue2":
                    SetAnimation(value, compassNeedle2);
                    break;
                case "DValue3":
                    SetAnimation(value, compassNeedle3);
                    break;
                case "DValue4":
                    SetAnimation(value, needle4);
                    break;

            }
        }
        #endregion

        #region SetAnimation

        private void SetAnimation(double value, Control needleItem)
        {
            if (needleItem.GetType() == typeof(CompassNeedle1))
            {
                RotateTransform rt = new RotateTransform(angle1, compassNeedle1.ActualWidth / 2, compassNeedle1.ActualHeight);
                DoubleAnimation a = new DoubleAnimation(angle1, angle1 = value, new TimeSpan(0, 0, 0, 3));

                compassNeedle1.RenderTransform = rt;

                rt.BeginAnimation(RotateTransform.AngleProperty, a);
            }
            else if (needleItem.GetType() == typeof(CompassNeedle2))
            {
                RotateTransform rt = new RotateTransform(angle2, compassNeedle2.ActualWidth / 2, compassNeedle2.ActualHeight);
                DoubleAnimation a = new DoubleAnimation(angle2, angle2 = value, new TimeSpan(0, 0, 0, 5));

                compassNeedle2.RenderTransform = rt;

                rt.BeginAnimation(RotateTransform.AngleProperty, a);
            }
            else if (needleItem.GetType() == typeof(CompassNeedle3))
            {

                RotateTransform rt = new RotateTransform(angle3, compassNeedle3.ActualWidth / 2, (compassNeedle3.ActualHeight / 2) + 1);
                DoubleAnimation a = new DoubleAnimation(angle3, angle3 = value, new TimeSpan(0, 0, 0, 7));

                compassNeedle3.RenderTransform = rt;

                rt.BeginAnimation(RotateTransform.AngleProperty, a);
            }
            else if (needleItem.GetType() == typeof(CTriangleNeedle))
            {

                //RotateTransform rt = new RotateTransform(angle4, needle4.ActualWidth / 2, needle4.ActualHeight);
                RotateTransform rt = new RotateTransform(angle4, needle4.ActualWidth / 2, needle4.ActualHeight + label_R);
                DoubleAnimation a = new DoubleAnimation(angle4, angle4 = value, new TimeSpan(0, 0, 0, 10));

                needle4.RenderTransform = rt;

                rt.BeginAnimation(RotateTransform.AngleProperty, a);
            }
        }
        #endregion

        #region SetScale

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

        #region DegreesToRadians

        private double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }
        #endregion
    }
}
