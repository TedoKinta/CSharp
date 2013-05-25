//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class Bit3OfInteger
{
    static void Main()
    {
        Console.WriteLine("Enter the coordinates of the point:");
        Console.Write("X=");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Y=");
        int y = int.Parse(Console.ReadLine());
        Console.Write("Enter the radius of the circle\nR=");
        int r = int.Parse(Console.ReadLine());

        bool IsInTheCircle = (x * x) + (y * y) <= r * r;

        Console.WriteLine("Is the point within a circle:\n"+IsInTheCircle);
    }
}
