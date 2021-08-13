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

namespace EGTest_Fixed
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int i = -10; i <= 10; i++)
            {
                Line horL = new Line();
                horL.X1 = 300 + i * 27;
                horL.X2 = 300 + i * 27;
                horL.Y1 = 195;
                horL.Y2 = 205;

                horL.Stroke = Brushes.Black;
                canvas.Children.Add(horL);

                Line verL = new Line();
                verL.X1 = 295;
                verL.X2 = 305;
                verL.Y1 = 200 + i * 18;
                verL.Y2 = 200 + i * 18;

                verL.Stroke = Brushes.Black;
                canvas.Children.Add(verL);

                if (i != 0)
                {
                    Label yName = new Label();
                    yName.Content = Math.Round(-0.2 * i, 2);
                    yName.FontSize = 9;
                    yName.HorizontalContentAlignment = HorizontalAlignment.Right;
                    canvas.Children.Add(yName);
                    Canvas.SetTop(yName, 190 + i * 18);
                    Canvas.SetLeft(yName, 270);

                    Label xName = new Label();
                    xName.Content = i;
                    xName.FontSize = 9;
                    xName.HorizontalContentAlignment = HorizontalAlignment.Center;
                    canvas.Children.Add(xName);
                    Canvas.SetTop(xName, 205);
                    Canvas.SetLeft(xName, 290 + i * 27);
                }
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            List<Point> points = new List<Point>();

            for (double x = -10; x <= 10; x += 1)
            {
                var y = 2;
                points.Add(new Point(x, -y));
            }

            DrawGraph(points);

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            List<Point> points = new List<Point>();

            for (double x = -10; x <= 10; x += 0.1)
            {
                var y = 2 * Math.Cos(x);
                points.Add(new Point(x, -y));
            }

            DrawGraph(points);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            List<Point> points = new List<Point>();

            for (double x = -10; x <= 10; x += 0.1)
            {
                var y = 2 * Math.Tan(x);

                if (y >= -2.1 && y <= 2.1)
                    points.Add(new Point(x, -y));
            }

            DrawGraph(points, true);
        }

        private void DrawGraph(List<Point> points, bool tan_fl = false)
        {
            GraphCanvas.Children.Clear();

            var w = canvas.ActualWidth * .9;
            var h = canvas.ActualHeight * .9;
            var pg = new PathGeometry();
            var ps = new List<PathSegment>();

            var rangeX = points.Max(p => p.X) - points.Min(p => p.X);
            var rangeY = 4;
            var scaleX = w / rangeX;
            var scaleY = h / rangeY;

            for (int i = 0; i < points.Count; i++)
            {
                points[i] = new Point(points[i].X * scaleX + 300, points[i].Y * scaleY + 200);
            }

            if (tan_fl == true)
            {
                for (int i = 0; i < points.Count - 1; i++)
                {
                    if (points[i].Y >= points[i + 1].Y)
                    {
                        DrawLine(points[i], points[i + 1]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < points.Count - 1; i++)
                {
                    DrawLine(points[i], points[i + 1]);
                }
            }
        }

        private void DrawLine(Point A, Point B)
        {
            Line vertL = new Line();
            vertL.X1 = A.X;
            vertL.X2 = B.X;
            vertL.Y1 = A.Y;
            vertL.Y2 = B.Y;

            vertL.Stroke = Brushes.Red;
            vertL.StrokeThickness = 2;
            GraphCanvas.Children.Add(vertL);
        }
    }
}
