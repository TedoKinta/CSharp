//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class DevideBy7and5
{
    static void Main()
    {
        Console.Write("Write a number to be checked:");
        int number = int.Parse(Console.ReadLine());

        bool DevideBy7and5 = ((number % 5 == 0) && (number % 7 == 0));

        Console.WriteLine("The number cen be devided be 5 and 7? \n"+ DevideBy7and5);
    }
}