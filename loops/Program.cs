using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhıleLoop();
            //DoWhileLoop();
            //ForEachLoop();

            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a prime number.");
            }
            else
            {
                Console.WriteLine("This is not a prime number.");
            }
            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                        i = number;
                }
            }
            return result;
        }
        
        private static void ForEachLoop()
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;

            } while (number >= 11);
        }

        private static void WhıleLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now numnber is {0}", number);
        }

        private static void ForLoop()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
        }
    }
}
