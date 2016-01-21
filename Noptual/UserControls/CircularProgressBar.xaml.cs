﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Noptual.UserControls
{
    /// <summary>
    /// Interaction logic for CircularProgressBar.xaml
    /// </summary>
    public partial class CircularProgressBar : UserControl
    {
        public CircularProgressBar()
        {
            InitializeComponent();
            Angle = (Percentage*360)/100;
            RenderArc();
        }

        public int Radius
        {
            get { return (int) GetValue(RadiusProperty); }
            set { SetValue(RadiusProperty, value); }
        }

        public Brush SegmentColor
        {
            get { return (Brush) GetValue(SegmentColorProperty); }
            set { SetValue(SegmentColorProperty, value); }
        }

        public int StrokeThickness
        {
            get { return (int) GetValue(StrokeThicknessProperty); }
            set { SetValue(StrokeThicknessProperty, value); }
        }

        public DoubleCollection StrokeDashArray
        {
            get { return (DoubleCollection) GetValue(StrokeDashArrayProperty); }
            set { SetValue(StrokeDashArrayProperty, value); }
        }

        public double Percentage
        {
            get { return (double) GetValue(PercentageProperty); }
            set { SetValue(PercentageProperty, value); }
        }

        public double Angle
        {
            get { return (double) GetValue(AngleProperty); }
            set { SetValue(AngleProperty, value); }
        }

        public static readonly DependencyProperty PercentageProperty =
            DependencyProperty.Register("Percentage", typeof (double), typeof (CircularProgressBar),
                new PropertyMetadata(65d, new PropertyChangedCallback(OnPercentageChanged)));

        public static readonly DependencyProperty StrokeThicknessProperty =
            DependencyProperty.Register("StrokeThickness", typeof (int), typeof (CircularProgressBar),
                new PropertyMetadata(5));

        public static readonly DependencyProperty StrokeDashArrayProperty =
            DependencyProperty.Register("StrokeDashArray", typeof (DoubleCollection), typeof (CircularProgressBar),
                new PropertyMetadata(null));

        public static readonly DependencyProperty SegmentColorProperty =
            DependencyProperty.Register("SegmentColor", typeof (Brush), typeof (CircularProgressBar),
                new PropertyMetadata(new SolidColorBrush(Colors.Red)));

        public static readonly DependencyProperty RadiusProperty =
            DependencyProperty.Register("Radius", typeof (int), typeof (CircularProgressBar),
                new PropertyMetadata(25, new PropertyChangedCallback(OnPropertyChanged)));

        public static readonly DependencyProperty AngleProperty =
            DependencyProperty.Register("Angle", typeof (double), typeof (CircularProgressBar),
                new PropertyMetadata(120d, new PropertyChangedCallback(OnPropertyChanged)));

        private static void OnPercentageChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            CircularProgressBar circle = sender as CircularProgressBar;
            circle.Angle = (circle.Percentage*360)/100;
        }

        private static void OnPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            CircularProgressBar circle = sender as CircularProgressBar;
            circle.RenderArc();
        }

        public void RenderArc()
        {
            Point startPoint = new Point(Radius, 0);
            Point endPoint = ComputeCartesianCoordinate(Angle, Radius);
            endPoint.X += Radius;
            endPoint.Y += Radius;

            pathRoot.Width = Radius*2 + StrokeThickness;
            pathRoot.Height = Radius*2 + StrokeThickness;
            Grid.Margin = new Thickness(StrokeThickness, StrokeThickness, 0, 0);

            bool largeArc = Angle > 180.0;

            Size outerArcSize = new Size(Radius, Radius);

            pathFigure.StartPoint = startPoint;

            if (startPoint.X == Math.Round(endPoint.X) && startPoint.Y == Math.Round(endPoint.Y))
                endPoint.X -= 0.01;

            arcSegment.Point = endPoint;
            arcSegment.Size = outerArcSize;
            arcSegment.IsLargeArc = largeArc;
        }

        private Point ComputeCartesianCoordinate(double angle, double radius)
        {
            // convert to radians
            double angleRad = (Math.PI/180.0)*(angle - 90);

            double x = radius*Math.Cos(angleRad);
            double y = radius*Math.Sin(angleRad);

            return new Point(x, y);
        }
    }
}