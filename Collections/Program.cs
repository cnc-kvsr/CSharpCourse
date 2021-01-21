using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            ////Sözlüğün değerlerine ulaşmak için
            //Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            //dictionary de bir collection'dır.bütün özellik ve metodlar geçerli.

            Console.WriteLine(dictionary.ContainsKey("glass"));//bool değeri döner.
            Console.WriteLine(dictionary.ContainsKey("table"));

            //ContainsKey ve ContainsValue dictionary'e özgü metodlar




            Console.ReadLine();

        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            Console.WriteLine(cities.Contains("İstanbul"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Engin" });
            //customers.Add(new Customer { Id = 2, FirstName = "Derin" });


            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Engin" },
                new Customer { Id = 2, FirstName = "Derin" }
            };


            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Salih"
            };
            customers.Add(customer2); // add metodu eleman eklemek için kull.

            customers.AddRange(new Customer[2]  //AddRange, var olan bir listeye array bazlı yeni bir liste eklemek için kulllanılır.
            {
                new Customer{Id=4, FirstName="Ali" },
                new Customer{Id=5 ,FirstName="Ayşe"}
            });

            //customers.Clear();//listedeki elemanları temizler.

            Console.WriteLine(customers.Contains(customer2));//listede aradığımız değer var mı diye bakmak için 

            var index = customers.IndexOf(customer2);//listedeki elemanın listede kaçıncı sırada olduğunu verir
            Console.WriteLine("Index: {0}", index);

            customers.Add(customer2);
            var index2 = customers.LastIndexOf(customer2);//aramaya sondan başlar
            Console.WriteLine("Index2: {0}", index2);

            customers.Insert(0, customer2);//İstediğin indexe değer eklemek için

            customers.Remove(customer2);//bulduğu ilk değeri uçurur
            //customers.RemoveAll(c=>c.FirstName=="Salih");//Müşterilerden ismi salih olanları bul ve sil. 

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            var count = customers.Count; //count eleman sayısını verir
            Console.WriteLine("Count: {0}", count);
        }

        class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
        }
    }
}
