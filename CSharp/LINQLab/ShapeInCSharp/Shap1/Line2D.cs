using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInCSharp.Shap1
{
    public class Line2D
    {
        public Point2D Start { get; }
        public Point2D End { get; }

        public Line2D(Point2D start, Point2D end)
        {
            Start = start;
            End = end;
        }

        public IEnumerable<Point2D> GetPoints()
        {
            int x1 = Start.X;
            int y1 = Start.Y;
            int x2 = End.X;
            int y2 = End.Y;

            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);

            int sx = x1 < x2 ? 1 : -1;
            int sy = y1 < y2 ? 1 : -1;
            int err = dx - dy;

            while (true)
            {
                yield return new Point2D(x1, y1);

                if (x1 == x2 && y1 == y2)
                    break;

                int e2 = 2 * err;

                if (e2 > -dy)
                {
                    err -= dy;
                    x1 += sx;
                }

                if (e2 < dx)
                {
                    err += dx;
                    y1 += sy;
                }
            }
        }
    }
}
