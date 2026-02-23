using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInCSharp.Shap1
{
    public class ConsoleRenderer : IRenderer
    {
        public void DrawLine(Line2D line)
        {
            foreach(var point in line.GetPoints())
            {
                  DrawPoint(point);
            }
        }

        public void DrawPoint(Point2D point)
        {
            if(point.X >=0 && point.Y >=0 && 
                point.X <Console.WindowWidth && 
                point.Y <Console.WindowHeight)
            {
                Console.SetCursorPosition(point.X, point.Y/2);
                Console.Write("▄ ▀");
            }
        }
    }
}
