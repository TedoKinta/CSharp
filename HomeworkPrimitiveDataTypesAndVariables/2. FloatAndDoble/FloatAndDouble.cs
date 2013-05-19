//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

using System;

class FloatAndDoble
{
    static void Main()
    {
        double doubleVar1 = 34.567839023;
        float floatVar1 = 12.345F;
        double doubleVar2 = 8923.1234857;
        float floatVar2 = 3456.091F;

        Console.WriteLine("double varialbes: {0}, {1};\nfloat variables: {2}, {3}.", doubleVar1, doubleVar2, floatVar1, floatVar2);
    }
}