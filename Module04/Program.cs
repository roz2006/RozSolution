using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of months to calculate the average:");
            string numberofMonth = Console.ReadLine();
            int n = int.Parse(numberofMonth);

            int[] monthlySalary = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input number {0} of the month salary:",i+1);
                monthlySalary[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(monthlySalary);
            Console.WriteLine("Sorted monthly salary is:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(monthlySalary[i]);
            }

            Console.WriteLine("Average salary of {0} months is {1}.", n, monthlySalary.Sum() / n);
            Console.ReadKey();
        }
    }
}
