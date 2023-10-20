using System;

public class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        if (length <= 0 || width <= 0)
        {
            throw new ArgumentException("lengths must be greater than 0");
        }

        this.length = length;
        this.width = width;
    }

    public override double Perimeter()
    {
        return 2 * (length + width);
    }

    public override double Area()
    {
        return length * width;
    }
}
