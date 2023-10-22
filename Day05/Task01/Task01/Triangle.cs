using System;
using System.Drawing;

   public class Triangle : Shape
{
    private double sideA;
    private double sideB;
    private double sideC;

    public Triangle(double a, double b, double c)
    {
        //triangle rule
        if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
        {
            throw new ArgumentException("Invalid triangle");
        }

        sideA = a;
        sideB = b;
        sideC = c;
    }

    public override double Perimeter()
    {
        return sideA + sideB + sideC;
    }

    public override double Area()
    {
        //area 
        double s = Perimeter() / 2.0;
        return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));

        //Or we can calculate the area by the sine between the two angles
    }
}
