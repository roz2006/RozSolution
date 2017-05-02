using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module05
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    int number = i * j;
                    if (number > 50)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.White;

                    string number_str = number.ToString();
                    Console.Write(number_str.PadLeft(5));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
