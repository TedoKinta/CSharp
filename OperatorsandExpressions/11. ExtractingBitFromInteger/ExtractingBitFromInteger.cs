//Write an expression that extracts from a given integer i the value of a  bit nugivenmber b. Example: i=5; b=2  value=1.

using System;

class ExtractingBitFromInteger
{
    static void Main()
    {

        Console.Write("Enter the number:");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Enter the position:");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;

        int v = (i & mask) >> p;

        Console.WriteLine("The value ot positon {0} is {1}", p, v);
    }
}