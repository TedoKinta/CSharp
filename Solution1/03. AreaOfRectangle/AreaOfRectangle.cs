//Write an expression that calculates rectangle’s area by given width and height.

using System;

class AreaOfRectangle
{
    static void Main()
    {
        Console.Write("Input the parameters of the rectangle:\nWidth:");
        int width= int.Parse(Console.ReadLine());
        Console.Write("Height:");
        int height = int.Parse(Console.ReadLine());

        Console.WriteLine("Area = {0}", width*height);
    }
}