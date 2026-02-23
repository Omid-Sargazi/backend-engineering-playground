using ShapeInCSharp;
using ShapeInCSharp.Shap1;

public class Program
{
       public static void Main()
    {
        Console.Clear();
        Console.CursorVisible = false;

        var renderer = new ConsoleRenderer();
        var point = new Point2D(10, 5);

        renderer.DrawPoint(point);


        var p1 = new Point2D(5, 5);
        var p2 = new Point2D(40, 15);

        var line = new Line2D(p1, p2);

        renderer.DrawLine(line);
        Console.ReadKey();
    }
}