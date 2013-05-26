//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Enter the parameters of the trapezoid:");
        Console.Write("A=");
        int a = int.Parse(Console.ReadLine());
        Console.Write("B=");
        int b = int.Parse(Console.ReadLine());
        Console.Write("H=");
        int h = int.Parse(Console.ReadLine());

        int S= ((a+b)/2)*h;

        Console.WriteLine("The area is:"+S);
    }
}