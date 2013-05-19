/*Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first 
two variables (mind adding an interval). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).*/

using System;

class StringsHelloAndWorld
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object HelloWorld = hello + " "+ world;
        string strHelloWorld = (string)HelloWorld;
        Console.WriteLine("String 1 is: {0}\nString 2 is: {1}\nObject is {2}\nString 3 is: {3}", hello, world, HelloWorld, strHelloWorld);
    }
}