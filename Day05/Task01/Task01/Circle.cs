using System;

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("radius must be greater than 0");
        }

        this.radius = radius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }
}
