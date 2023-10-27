using System;

class Triangle
{
    private double side1;
    private double side2;
    private double side3;

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
        {
            throw new ArgumentException("Invalid sides");
        }
        side1 = a;
        side2 = b;
        side3 = c;
    }
    public double CalculateArea()
    {
        //triangle area using Heron's formula
        double s = (side1 + side2 + side3) / 2;
        double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        return area;

        // Or another formula of sin and 2 sides where SIN is
    }

    public double CalculatePerimeter()
    {
        double perimeter = side1 + side2 + side3;
        return perimeter;
    }


    //OverLoad Method 
    public static bool operator ==(Triangle t1, Triangle t2)
    {
        return t1.CalculateArea() == t2.CalculateArea();
    }

    public static bool operator !=(Triangle t1, Triangle t2)
    {
        return t1.CalculateArea() != t2.CalculateArea();
    }
    public static bool operator >(Triangle t1, Triangle t2)
    {
        return t1.CalculateArea() > t2.CalculateArea();
    }
    public static bool operator <(Triangle t1, Triangle t2)
    {
        return t1.CalculateArea() < t2.CalculateArea();
    }
    public static Triangle operator +(Triangle t1, Triangle t2)
    {
        double newSide1 = t1.side1 + t2.side1;
        double newSide2 = t1.side2 + t2.side2;
        double newSide3 = t1.side3 + t2.side3;
        return new Triangle(newSide1, newSide2, newSide3);
    }
    public static explicit operator Triangle(double sideLength)
    {
        if (sideLength <= 0)
        {
            throw new ArgumentException("Invalid side length");
        }
        return new Triangle(sideLength, sideLength, sideLength);
    }
    //public override bool Equals(object obj)
    //{
    //    if (obj is Triangle other)
    //    {
    //        return this == other;
    //    }
    //    return false;
    //}

    //To remember with Hashcode which triangle area and perimeter was.
    public override int GetHashCode()
    {
        return CalculateArea().GetHashCode();
    }
    public override string ToString()
    {
        return $"Triangle [Side1: {side1}, Side2: {side2}, Side3: {side3}]";
    }
    public static Triangle CreateFromConsoleInput()
    {
        Console.WriteLine("Enter side lengths");
        string input = Console.ReadLine();
        string[] sides = input.Split(' ');

        if (sides.Length != 3 || !double.TryParse(sides[0], out double a) || !double.TryParse(sides[1], out double b) || !double.TryParse(sides[2], out double c))
        {
            throw new ArgumentException("Invalid input.");
        }

        return new Triangle(a, b, c);
    }
}
