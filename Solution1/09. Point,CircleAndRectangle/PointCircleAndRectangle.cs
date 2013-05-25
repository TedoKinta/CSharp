//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class PointCircleAndRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter the coordinates of the point:");
        Console.Write("X=");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Y=");
        int y = int.Parse(Console.ReadLine());
        int radius = 3;

        bool InTheCircle = ((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= radius * radius;
        bool OutofRectangle= (x < 1) || (x > 7) || (y > -1) || (y < -3);

        Console.WriteLine("The point is on the Circle\n{0}\nThe point is out of the rectangle\n{1}", InTheCircle, OutofRectangle);
    }
}