using FigureTask.Interface;

namespace FigureTask.Sheaps;

public class Triangle : ISheap
{
    private readonly double _side1;
    private readonly double _side2;
    private readonly double _side3;

    private double _halfPerimetr;

    public Triangle(double side1, double side2, double side3)
    {
        _side1 = side1;
        _side2 = side2;
        _side3 = side3;
        _halfPerimetr = (_side1 + _side2 + _side3) / 2;
    }

    public double Area()
    {
        return Math.Sqrt(_halfPerimetr * (_halfPerimetr - _side1) * (_halfPerimetr - _side2) * (_halfPerimetr - _side3));
    }

    public bool IsRectTriangle()
    {
        if (Math.Pow(_side1, 2) + Math.Pow(_side2, 2) == Math.Pow(_side3, 2) ||
            Math.Pow(_side1, 2) + Math.Pow(_side3, 2) == Math.Pow(_side2, 2) ||
            Math.Pow(_side2,2) + Math.Pow(_side3,2) == Math.Pow(_side1, 2))
        {
            return true;
        }

        return false;
    }
}