using FigureTask.Interface;
using FigureTask;
using FigureTask.Sheaps;

class Program
{
    public static void Main()
    {
        Triangle triangle = new Triangle(23, 34, 56);
        Console.WriteLine(triangle.Area());

        Square square = new Square(5);
        Console.WriteLine(square.Area());





    }
}