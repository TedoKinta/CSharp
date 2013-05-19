/*Declare two string variables and assign them with following value:
The "use" of quotations causes difficulties.
Do the above in two different ways: with and without using quoted strings.*/

using System;

class StringsAndQuotations
{
    static void Main()
    {
        string FirstString = "The \"use\" of quotations causes difficulties.";
        string SecondString = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("First string: {0}\nSecond String: {1}", FirstString, SecondString);
    }
}