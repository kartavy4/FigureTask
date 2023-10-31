using FigureTask.Interface;

namespace FigureTask.Sheaps;


public class Circle : ISheap
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double Area()
    {
        return (_radius * _radius) * Math.PI;
    }
}