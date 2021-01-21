using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dörtİşlem dörtİşlem = new Dörtİşlem(2, 3);
            //Console.WriteLine(dörtİşlem.Topla2());  //topla2 constructordaki değerleri baz alır
            //Console.WriteLine(dörtİşlem.Topla(2, 3));

            var tip = typeof(Dörtİşlem);

            //Dörtİşlem dörtİşlem=(Dörtİşlem)Activator.CreateInstance(tip,6,7);
            //Console.WriteLine(dörtİşlem.Topla(4, 5));
            //Console.WriteLine(dörtİşlem.Topla2()); 

            var instance = Activator.CreateInstance(tip, 6, 7);

            Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance,null));   //GetMethod ile istedğimiz metoda ulaşabiliyoruz.İnvoke ile onu kullanabiliyoruz

            //MethodInfo methodInfo = instance.GetType().GetMethod("Topla 2");
            //Console.WriteLine(methodInfo.Invoke(instance, null));

            Console.WriteLine("----------------");
            var metodlar = tip.GetMethods();

            foreach (var info in metodlar)
            {
                Console.WriteLine("Metod adı: {0}", info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre : {0}", parameterInfo.Name);
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : {0}", attribute.GetType().Name);
                }
            }

            
            Console.ReadLine();
        }
    }

    public class Dörtİşlem
    {
        private int _sayı1;
        private int _sayı2;
        public Dörtİşlem(int sayı1, int sayı2)
        {
            _sayı1 = sayı1;
            _sayı2 = sayı2;
        }
        public Dörtİşlem()
        {

        }
        public int Topla(int sayı1, int sayı2)
        {
            return sayı1 + sayı2;
        }
        public int Carp(int sayı1, int sayı2)
        {
            return sayı1 * sayı2;
        }
        public int Topla2()
        {
            return _sayı1 + _sayı2;
        }

        [MetodName("Çarpma")]
        public int Carp2()
        {
            return _sayı1 * _sayı2;
        }

    }

    public class MetodNameAttribute : Attribute
    {
        public MetodNameAttribute(string name)
        {

        }
    }
}
