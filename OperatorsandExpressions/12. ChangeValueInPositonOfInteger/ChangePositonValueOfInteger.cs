/*We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to 
hold the value v at the position p from the binary representation of n.
	Example: n = 5 (00000101), p=3, v=1  13 (00001101)
	n = 5 (00000101), p=2, v=0  1 (00000001)*/

using System;

class ChangePositonValueOfInteger
{
    static void Main()
    {

        Console.Write("Enter the number:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(
        Convert.ToString(n, 2).PadLeft(32, '0'));


        Console.Write("Enter the value:");
        int v = int.Parse(Console.ReadLine());
        if ((v != 0) && (v != 1))
        {
            Console.WriteLine("Enter a correct value (only 0 and 1)");
        }
        Console.Write("Enter the position:");
        int p = int.Parse(Console.ReadLine());
        
        //setting the chosen bit to 0
        int mask = ~(1 << p);
        n = n & mask;
        
        //setting the bit to the chosen value
        mask = v << p;
        n = n | mask;

        Console.WriteLine(
        Convert.ToString(n, 2).PadLeft(32, '0'));

    }
}