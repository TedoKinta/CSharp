using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        char copyright = '\u00A9';
        Console.Write("Please, enter the number of the rows: ");
        int n = int.Parse(Console.ReadLine());
        for (int row = 1; row < n; row++)                           // it's draw the top of the isosceles triangle
        {
            int prevRow = row - 1;                                  // the previous row number
            for (int col = 1; col <= 2 * n - 1; col++)
            {
                if (col < n - prevRow || col > n + prevRow)
                {
                    Console.Write(" ");
                }
                else
                {
                    if (col < n - (prevRow - 1) || col > n + (prevRow - 1))     // this remove the interior part
                    {
                        Console.Write(copyright);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();
        }
        for (int i = 1; i <= 2 * n - 1; i++)                            // it's draw the bottom side
        {
            if (i % 2 == 0)
            {
                Console.Write(" ");
            }
            else
            {
                Console.Write(copyright);
            }
        }
        Console.WriteLine("\n");
    }
}
