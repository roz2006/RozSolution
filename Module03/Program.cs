using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //var integer = 199;
            //var letter = 'a';
            //var a_string = "hello world!";
            //var decimial_number = 19.343243432;
            //var float_number = fetchFloat();

            //Console.WriteLine(float_number);
            //Console.ReadKey();

            //person personeOne = new person();
            //personeOne.sex = gender.Man;
            //personeOne.age = 24;
            //personeOne.job = "Developer";

            Console.WriteLine("Input the person's info at {0:d}.", DateTime.Now);
            person personOne = ReadPerson();
            PrintPerson(personOne);
            Console.ReadKey();
        }

        enum gender { Man, Woman }
        struct person
        {
            public string name;
            public gender sex;
            public int age;
            public string job;
        }

        /// <summary>
        /// Print out the person's info.
        /// </summary>
        /// <param name="p"></param>
        private static void PrintPerson(person p)
        {
            Console.WriteLine("Person info registered at {0:ddMMyy}.", DateTime.Now);
            Console.WriteLine("Info for {0}.", p.name);
            Console.WriteLine("Gender is {0}.", p.sex);
            Console.WriteLine("Age is {0}.", p.age);
            Console.WriteLine("Job is {0}.", p.job);
        }

        /// <summary>
        /// Read information of the person
        /// </summary>
        /// <returns></returns>
        private static person ReadPerson()
        {
            person p = new person();

            Console.WriteLine("Who is to be registered? Full name is:");
            p.name = Console.ReadLine();

            Console.WriteLine("Input this person's gender:");
            string sex = Console.ReadLine();
            while (sex != "Man" && sex != "Woman")
            {
                Console.WriteLine("Gender not recognised, please input Man or Woman.");
                sex = Console.ReadLine();
            }

            if (sex == "Man")
                p.sex = gender.Man;
            else if (sex == "Woman")
                p.sex = gender.Woman;

            Console.WriteLine("Input this person's age:");
            p.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input this person's job:");
            p.job = Console.ReadLine();

            return p;
        }

    }
}
