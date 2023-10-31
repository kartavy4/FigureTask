using FigureTask.Interface;
namespace FigureTask.Sheaps;

public class Square : ISheap
{
    private double _side1;

    public Square(double side1)
    {
        _side1 = side1;
    }


    public double Area()
    {
        return _side1 * _side1;
    }
}