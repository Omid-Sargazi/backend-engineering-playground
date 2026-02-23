using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInCSharp.Shap1
{
    public interface IRenderer
    {
        void DrawPoint(Point2D point);
        void DrawLine(Line2D line);
    }
}
