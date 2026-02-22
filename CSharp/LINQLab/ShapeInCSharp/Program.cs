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
        Console.ReadKey();
    }
}