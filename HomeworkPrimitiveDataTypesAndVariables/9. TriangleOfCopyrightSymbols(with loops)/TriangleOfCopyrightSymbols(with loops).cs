/*A marketing firm wants to keep record of its employees. Each record would have the following characteristics – first name, family name, age, gender (m or f), 
ID number, unique employee number (27560000 to 27569999). Declare the variables needed to keep the information for a single employee using appropriate data types 
and descriptive names.*/

using System;

class TriangleOfCopyrightSymbolsWithLoops
{
    static void Main()
    {
        int rows = 3;
        char CopyRight = '\u00A9';
        int intervals = rows;
        int chars = 1;

        for (int u = 0; u < rows; u++) //every row
        {

            intervals -= 1;
            for (int i = 0; i < intervals; i++) //printing the intervals for the single row
            {
                Console.Write(" ");
            }

            
            for (int c = 0; c < chars; c++) //printing the (c) for the single row
            {
                Console.Write(CopyRight);
            }
            chars += 2;
            Console.WriteLine();
        }
    }
}