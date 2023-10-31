using FigureTask.Interface;
namespace FigureTask.Sheaps;

public class Rectangle : ISheap
{
    private double _side1;
    private double _side2;

    public Rectangle(double side1 ,double side2)
    {
        _side1 = side1;
        _side2 = side2;
    }


    public double Area()
    {
        return _side1 * _side2;
    }
}