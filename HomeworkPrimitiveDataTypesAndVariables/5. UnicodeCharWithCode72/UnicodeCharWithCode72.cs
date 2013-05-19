/*Declare a character variable and assign it with the symbol that has Unicode code 72. Hint: first use the Windows 
Calculator to find the hexadecimal representation of 72.*/

using System;

class UnicodeCharWithCode72
{
    static void Main()
    {
        char CharacterWithCode72 = '\u0048';

        Console.WriteLine("The representation of Unicode {0} code  is \"{1}\".",(int)CharacterWithCode72, CharacterWithCode72);
    }
}