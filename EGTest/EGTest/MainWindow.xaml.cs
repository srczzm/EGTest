using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace EGTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public static bool IsTang = false;
        public static readonly DependencyProperty PointsProperty = DependencyProperty.Register(
            "Points", typeof(ObservableCollection<Point>), typeof(MainWindow), new PropertyMetadata(default(ObservableCollection<Point>)));

        public List<Line> linesListH = new List<Line>(20);
        public List<Line> linesListV = new List<Line>(20);
        public List<Label> axisXNames = new List<Label>();
        public List<Label> axisYNames = new List<Label>();

        public ObservableCollection<Point> Points
        {
            get
            {
                return (ObservableCollection<Point>)GetValue(PointsProperty);
            }
            set
            {
                SetValue(PointsProperty, value);
            }
        }


        public MainWindow()
        {
            InitializeComponent();

            for (int i = -10; i <= 10; i++)
            {
                Line horL = new Line();
                horL.X1 = i * 20;
                horL.X2 = i * 20;
                horL.Y1 = 195;
                horL.Y2 = 205;

                horL.Stroke = Brushes.Black;
                linesListH.Add(horL);
                canvas.Children.Add(horL);

                Line verL = new Line();
                verL.X1 = 295;
                verL.X2 = 305;
                verL.Y1 = i * 20;
                verL.Y2 = i * 20;

                verL.Stroke = Brushes.Black;
                linesListV.Add(verL);
                canvas.Children.Add(verL);

                if (i % 2 == 0)
                {
                    Label yName = new Label();

                    yName.Content = Math.Round(-0.2 * i, 2);
                    yName.FontSize = 9;

                    canvas.Children.Add(yName);
                    axisYNames.Add(yName);

                    Label xName = new Label();

                    xName.Content = i;
                    xName.FontSize = 9;

                    canvas.Children.Add(xName);
                    axisXNames.Add(xName);
                }
            }
        }

        private void canvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Canvas.SetLeft(YAxis, canvas.ActualWidth / 2);

            Canvas.SetLeft(XAxis, canvas.ActualWidth - 20);
            Canvas.SetTop(XAxis, canvas.ActualHeight / 2 - 25);

            for (int i = 0; i < linesListH.Count; i++)
            {
                linesListH[i].X1 = i * canvas.ActualWidth * 0.8 / 20;
                linesListH[i].X2 = i * canvas.ActualWidth * 0.8 / 20;

                Canvas.SetLeft(linesListH[i], canvas.ActualWidth * 0.1);
                Canvas.SetBottom(linesListH[i], canvas.ActualHeight / 2 - 5);

                linesListV[i].Y1 = i * canvas.ActualHeight * 0.8 / 20;
                linesListV[i].Y2 = i * canvas.ActualHeight * 0.8 / 20;

                Canvas.SetRight(linesListV[i], canvas.ActualWidth / 2 - 5);
                Canvas.SetTop(linesListV[i], canvas.ActualHeight * 0.1);
            }

            for (int i = 0; i < axisYNames.Count; i++)
            {
                Canvas.SetTop(axisYNames[i], canvas.ActualHeight * 0.1 + linesListV[i * 2].Y1 - 10);
                Canvas.SetLeft(axisYNames[i], canvas.ActualWidth / 2);

                Canvas.SetTop(axisXNames[i], canvas.ActualHeight / 2);
                Canvas.SetLeft(axisXNames[i], canvas.ActualWidth * 0.1 + linesListH[i * 2].X1 - 10);

                if (i == 5)
                {
                    axisXNames[i].Visibility = Visibility.Hidden;
                    axisYNames[i].Visibility = Visibility.Hidden;
                }
            }

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            IsTang = false;
            List<Point> points = new List<Point>();

            for (double x = -10; x <= 10; x += 1)
            {
                var y = 2;
                points.Add(new Point(x, -y));
            }

            for (int i = 0; i < axisYNames.Count; i++)
            {
                axisYNames[i].Content = -Math.Round(-2f + i * 4f / 10, 1);
            }

            Points = new ObservableCollection<Point>(points); 
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            IsTang = false;
            List<Point> points = new List<Point>();

            for (double x = -10; x <= 10; x += 0.1)
            {
                var y = 2 * Math.Cos(x);
                points.Add(new Point(x, -y));
            }

            for (int i = 0; i < axisYNames.Count; i++)
            {
                axisYNames[i].Content = -Math.Round(-2f + i * 4f / 10, 1);
            }

            Points = new ObservableCollection<Point>(points);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            IsTang = true;
            List<Point> points = new List<Point>();

            for (double x = -10; x <= 10; x += 0.1)
            {
                var y = 2 * Math.Tan(x);
                points.Add(new Point(x, -y));
            }

            double pMax = points.Max(p => p.Y);
            double pMin = points.Min(p => p.Y);

            for (int i = 0; i < axisYNames.Count; i++)
            {
                axisYNames[i].Content = -Math.Round(pMin + i * (Math.Abs(pMax) + Math.Abs(pMin)) / 10, 1);
            }
                
            Points = new ObservableCollection<Point>(points);
        }
    }
}
