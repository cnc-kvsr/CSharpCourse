using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Kevser Canca";

            var result = sentence.Length;  //Kullanılan karakter sayısını verir.
            var result2 = sentence.Clone(); //Cümleyi klonlar.
            sentence = "My name is Derin Demiroğ";

            bool result3 = sentence.EndsWith("ğ"); //Cümle tırnak içinde belirtilen karakter ile bitiyorsa true aksi halde false.
            bool result4 = sentence.StartsWith("My name"); //Cümle tırnak içinde belirtilen karakter ile başlıyorsa true aksi halde false.

            var result5 = sentence.IndexOf("name");/*Tırnak içindeki ifadenin kaçıncı karakterde başladığını..
                                                    * bir metnin içinde bir ifadeyi aramak için sıklıkla kullanılır.*/
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" "); //Aramaya sondan başlar.
            var result8 = sentence.Insert(0, "Hello "); //Bir string ifadeye başka bir metni yerleştirmek için kullanılır.
            var result9 = sentence.Substring(3, 4); //Metni parçalamak için kull.
            var result10 = sentence.ToLower(); //Bütün karakterleri küçük harfe çevirmeye yarar.
            var result11 = sentence.ToUpper(); //Bütün karakterleri büyük harfe çevirmeye yarar.
            var result12 = sentence.Replace(" ", "-"); //Metin içerisinde belli karakterleri değiştirmek için kull.
            var result13 = sentence.Remove(2, 5); //Metin içerisinde belli bir indexten sonrasını atmak için kull.

            Console.WriteLine(result13);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";

            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
