using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array lerde kullanım şekilleri 1:
            //string[] students = new string[3];
            //students[0] = "Engin";
            //students[1] = "Derin";
            //students[2] = "Salih";

            // Array lerde kullanım şekilleri 2
            //string[] students = new string[3] { "Engin", "Derin", "Salih" };

            //string[] students2 = { "Engin", "Derin", "Salih" };
            //students2[2] = "Ali";  /*{bu şekilde dizinin 2. elemanını değiştirip Ali yapmış olduk.}*/

            //foreach (var student in students2)
            //{
            //    Console.WriteLine(student);
            //}

            /*Multidimensional arrays*/
            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Manisa" },

            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("**********");
            }

        //Console.WriteLine();
            Console.ReadLine();



                    
        }
}
}
