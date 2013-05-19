//Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true


using System;


class ComparesFloatingPointNumbers
{
    static void Main()
    {
        Console.Write("First number for comparison: " );
        float firstNumber = float.Parse(Console.ReadLine());
        Console.Write("Second number for comparison: ");
        float secondNumber = float.Parse(Console.ReadLine());
        bool equal = (firstNumber == secondNumber);
        Console.WriteLine("The two number are: {0} and {1}.\nAre the numbers equal  {2}",firstNumber, secondNumber, equal);
    }
}