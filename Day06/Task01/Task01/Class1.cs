static void Main(string[] args)
{
    Triangle t1 = Triangle.CreateFromConsoleInput();
    Triangle t2 = Triangle.CreateFromConsoleInput();

    Console.WriteLine("Triangle 1: " + t1);
    Console.WriteLine("Triangle 2: " + t2);

    if (t1 == t2)
        Console.WriteLine("Triangles have the same area.");
    else if (t1 > t2)
        Console.WriteLine("Triangle 1 has a larger area.");
    else
        Console.WriteLine("Triangle 2 has a larger area.");

    Triangle sum = t1 + t2;
    Console.WriteLine("Sum of triangles: " + sum);
    double sideLength = 5.0;
    Triangle equilateral = (Triangle)sideLength;
    Console.WriteLine("Equilateral Triangle: " + equilateral);
}
