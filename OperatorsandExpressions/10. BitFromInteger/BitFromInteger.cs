//Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.

using System;

class BitFromInteger
{
    static void Main()
    {
        Console.Write("Enter the number:");
        int i = int.Parse(Console.ReadLine());

        Console.Write("Enter the position:");
        int b = int.Parse(Console.ReadLine());

        bool BitIsOne = (i & (1<<b)) >> b == 1;

        Console.WriteLine("The bit on the selected position is 1:\n"+ BitIsOne);
    }
}