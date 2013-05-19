//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;


class ValueExchange
{
    static void Main()
    {
        int val1 = 5;
        int val2 = 10;
        int holder;

        Console.WriteLine("Value 1 = {0}\nValue 2 = {1}", val1, val2);
        Console.WriteLine("Exchanging values\n");
        holder = val1;
        val1 = val2;
        val2 = holder;
        Console.WriteLine("Value 1 = {0}\nValue 2 = {1}", val1, val2);
    }
}