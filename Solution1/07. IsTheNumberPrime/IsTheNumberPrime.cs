//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class IsTheNumberPrime
{
    static void Main()
    {
        Console.Write("Enter a number to be checked:");
        int n = int.Parse(Console.ReadLine());

        if (n<=100 && n>0)
        {
            bool IsPrime = (n % 2 != 0) && (n % 3 != 0) && (n % 5 != 0);

            Console.WriteLine("Is the number Prime:\n"+IsPrime);
        }
        else
        {
            Console.WriteLine("The number isn't in the interval (0;100)");
        }
    }
}