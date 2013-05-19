/*A marketing firm wants to keep record of its employees. Each record would have the following characteristics – first name, family name, age, gender (m or f), 
ID number, unique employee number (27560000 to 27569999). Declare the variables needed to keep the information for a single employee using appropriate data types 
and descriptive names.*/

using System;
using System.Text;

namespace Task9IsoscalesTriangle
{
    class TriangleOfCopyrightSymbol
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            char copyright ='\u00a9';
            Console.WriteLine(@"  {0}
 {0}{0}{0}
{0}{0}{0}{0}{0}", copyright);
        }
    }
}