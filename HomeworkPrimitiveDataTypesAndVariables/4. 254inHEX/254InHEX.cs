//Declare an integer variable and assign it with the value 254 in hexadecimal format. Use Windows Calculator to find its hexadecimal representation.

using System;

class NumberInHEX
{
    static void Main()
    {
        byte NumberInHEX= 0xFE;
        Console.WriteLine("The number {0} in hexademical is {0:X}", NumberInHEX);
    }
}