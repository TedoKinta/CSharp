//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class Bit3OfInteger
{
    static void Main()
    {

        Console.Write("Enter number to be checked:");
        int number = int.Parse(Console.ReadLine());
        int p = 2;
        int mask = 1;

        int result = (number >> p) & mask;
        
        Console.WriteLine("The 3rd bit is: "+result);
    }
}