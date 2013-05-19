/*Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table 
of characters on the console.*/

using System;
using System.Text;

class PrintASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.ASCII;
        Console.WriteLine("Dec, Hex, Char");
        for (int n = 32; n < 127; n++) //starts from 32 becouse the characters from 0-31 cannot be displayed
        {
            Console.WriteLine("{0} - {0:X} - {1}", n, (char)n);
        }
    }

}