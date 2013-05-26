//* Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

//The answer is similar to the Ex 13.
using System;

class ExchangeBitsInInteger
{
    static void Main()
    {

        Console.Write("Enter the parameters:");
        int Number = int.Parse(Console.ReadLine());
        Console.WriteLine(
            Convert.ToString(Number, 2).PadLeft(32, '0'));
        Console.Write("position of the last copy bit:");
        int LastCopyBit = int.Parse(Console.ReadLine()); //the position of the last bit of the copy bits
        Console.Write("position of the last paste bit:");
        int LastPasteBit = int.Parse(Console.ReadLine()); //the position of the last bit of the paste bits
        Console.Write("number of bits to be copyed:");
        int NumberOfBits = int.Parse(Console.ReadLine()); //number of bits to be copyed

        int mask = ~(((1 << NumberOfBits) - 1) << (LastPasteBit - NumberOfBits + 1));

        Number = Number & mask; //setting paste bits to 0
        mask = ~mask << (LastCopyBit - LastPasteBit) & Number; //copying the bits
        mask = mask >> (LastCopyBit - LastPasteBit);
        Number = Number | mask;  //pasting the bits

        Console.WriteLine("After exchange:\n" +
            Convert.ToString(Number, 2).PadLeft(32, '0'));
    }
}
