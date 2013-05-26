//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangeBitsInInteger
{
    static void Main()
    {

        Console.Write("Enter the number:");
        int Number = int.Parse(Console.ReadLine());
            Console.WriteLine(
                Convert.ToString(Number, 2).PadLeft(32, '0'));
        int LastCopyBit = 26; //the position of the last bit of the copyed bits
        int LastPasteBit = 5; //the position of the last bit of the paste bits
        int NumberOfBits = 3; //number of bits to be copyed
        int mask = ~(((1 << NumberOfBits) - 1) << (LastPasteBit - NumberOfBits + 1));

        Number = Number & mask; //setting paste bits to 0
        mask = ~mask << (LastCopyBit - LastPasteBit) & Number; //copying the bits
        mask = mask >> (LastCopyBit - LastPasteBit);
        Number = Number | mask;  //pasting the bits

        Console.WriteLine("After exchange:\n"+
            Convert.ToString(Number, 2).PadLeft(32, '0'));
    }
}
