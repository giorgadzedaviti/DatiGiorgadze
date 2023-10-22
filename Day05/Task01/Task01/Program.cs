using System;

public abstract class Shape
{
    public abstract double Perimeter();
    public abstract double Area();


    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose a geometric shape:");
                Console.WriteLine("1 - Triangle");
                Console.WriteLine("2 - Rectangle");
                Console.WriteLine("3 - Circle");
                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Shape shape = null;

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("enter the side lengths (a, b, c) of the triangle:");
                            double sideA = GetPositiveDouble("side A: ");
                            double sideB = GetPositiveDouble("side B: ");
                            double sideC = GetPositiveDouble("side C: ");
                            shape = new Triangle(sideA, sideB, sideC);
                            break;

                        case 2:
                            Console.WriteLine("enter the side lengths (a, b) of the rectangle:");
                            double length = GetPositiveDouble("length: ");
                            double width = GetPositiveDouble("width: ");
                            shape = new Rectangle(length, width);
                            break;

                        case 3:
                            Console.WriteLine("enter the radius ");
                            double radius = GetPositiveDouble("Radius: ");
                            shape = new Circle(radius);
                            break;

                        default:
                            Console.WriteLine("Invalid choice");
                            continue;
                    }

                    double area = shape.Area();
                    double perimeter = shape.Perimeter();

                    //area as a floating-point number with 2 decimal places.
                    Console.WriteLine($"Area: {area:F2}");
                    Console.WriteLine($"Perimeter: {perimeter:F2}");
                }
            }

            //method is used to ensure that the side lengths or radius entered are positive values.
            static double GetPositiveDouble(string prompt)
            {
                double value;
                while (true)
                {
                    Console.Write(prompt);
                    if (double.TryParse(Console.ReadLine(), out value) && value > 0)
                    {
                        return value;
                    }
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            }
        }

    }
}
