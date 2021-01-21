using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();  //void olan ve parametre almayan operasyonlara delegelik yapıyor
    public delegate void MyDelegate2(string text);  //parametreli ve void

    public delegate int MyDelegate3(int number1, int number2); //int döndüren

    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;

            myDelegate -= customerManager.SendMessage;

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Çarp;
            var sonuc=myDelegate3(5, 7);
            Console.WriteLine(sonuc);

            myDelegate2("Hello!");

            myDelegate();
            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be Careful!");
        }
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    public class Matematik
    {
        public int Topla(int sayı1,int sayı2)
        {
            return sayı1 + sayı2;
        }
        public int Çarp(int sayı1, int sayı2)
        {
            return sayı1 * sayı2;
        }
    }
}
