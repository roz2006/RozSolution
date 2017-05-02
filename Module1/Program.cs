using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Input a number:");
            int number= Convert.ToInt32(Console.ReadLine());
            PrintNumber.PrintInteger(number);
            Console.ReadKey();
            
        }
    }

    class PrintNumber
    {
        public static void PrintInteger(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
