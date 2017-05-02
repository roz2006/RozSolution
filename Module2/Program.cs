using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What is your name?");

            string Name = Console.ReadLine();
            Name = Name.ToUpper();

            Console.WriteLine("Welcome {0}", Name);
            
            Console.WriteLine("Today is {0:d}", DateTime.Today);
            Console.ReadKey();
            
        }
 
        /// <summary>
        /// 1313131321
        /// </summary>
        private static void MyTest()
        {

        }
    }
}
