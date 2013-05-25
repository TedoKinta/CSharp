//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

using System;

class IsThe3rdDegit7
{
    static void Main()
    {
        Console.Write("Enter number to be checked:");
        int number = int.Parse(Console.ReadLine());

        bool ThirdDegitIs7= ((number/100)%10)==7;

        Console.WriteLine("Is the 3rd degit of the number 7? \n"+ ThirdDegitIs7);
    }

}
