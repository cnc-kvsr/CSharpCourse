using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            //değer tiplerde atamalar tamamen değer üzerinden gerçekleşir.
            //sonradan atanan number1 in etkisi yok!!!
            Console.WriteLine(number2);


            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" };
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" };
            cities2 = cities1; //cities2 nin referansı eşittir cities1in referansı demek...
            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]);

            
            
            Console.ReadLine();

        }
    }
}
