using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace EGTest
{
    class PointsToPathConverter : IMultiValueConverter
    {

        #region Implementation of IMultiValueConverter

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var points = values[0] as IEnumerable<Point>;

            if (points == null)
            {
                return null;
            }

            var w = (double)values[1] * 0.8;
            var h = (double)values[2] * 0.8;
            var pg = new PathGeometry();
            var ps = new List<PathSegment>();
                                             
            var rangeX = points.Max(p => p.X) - points.Min(p => p.X);
            var rangeY = points.Max(p => p.Y) - points.Min(p => p.Y);
            var scaleX = w / rangeX;

            if (rangeY == 0)
                rangeY = 4;

            var scaleY = h / rangeY;

            points = points.Select(p => new Point(p.X * scaleX, p.Y * scaleY));

            ps.Add(new PolyLineSegment(points, true));

            var pf = new PathFigure(points.First(), ps, false);
            pg.Figures.Add(pf);
            
            return pg;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}
