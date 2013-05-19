/*Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null 
literal to them and see the result.*/

using System;

class NullsAndVAriables
{
    static void Main()
    {
        int? nullableInt = null;
        double? nullableDouble = null;

        Console.Write("int with null: {0}\ndouble with null: {1}\n", nullableInt, nullableDouble);

        Console.WriteLine("Adding some values to them:");
        Console.Write("Int?: ");
        nullableInt = int.Parse(Console.ReadLine());
        Console.Write("Double?: ");
        nullableDouble = double.Parse(Console.ReadLine());

        Console.WriteLine("Int with value: {0}\nDobule with value: {1}", nullableInt, nullableDouble);
    }
}
