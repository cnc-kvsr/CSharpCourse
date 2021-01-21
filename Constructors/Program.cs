using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            // () constructor ın parametresiz bir şekilde çalıştırılması anlamına gelir
            customerManager.List();

            Product product = new Product { Id = 1, Name = "Laptop" };
            Product product2 = new Product(2, "Computer");

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10;

            Utilities.Validate();

            Manager.DoSomething(); //static metodu direk sınıf ismi üzerinden çağırabiliz
            Manager manager = new Manager(); //static olmayanı instance ile çağırabiliriz
            manager.DoSomething2();


            Console.ReadLine();

        }
    }

    class CustomerManager
    {
        private int _count = 15;  //Private bir field adlandırması alt çizgi ile başlar.
        public CustomerManager(int count) //metod halindeyse alt çizgi kullanılmaz
        {
            _count = count;
        }

        public CustomerManager()
        {

        }

        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }
    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;

        public Product(int id, string _name)
        {
            _id = id;        /* yukardaki Id ve name kullanıcının gönderdiği
                              * Id ve name e eşitlenir.*/
            _name = Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }

    //constructor ı daha profesyonel bir ortamda nasıl kull.
    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class EmployeeManager  
    {
        private ILogger _logger;  //constructor ınjection
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }

    class BaseClass //Base sınıfa parametre gönderme (constructor özelliklerinden)
    {
        string _entity;

        public BaseClass(string entity)  //Base class ın bir tane constructorı var demektir
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }

    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)  //Base e değer gönderme
        {

        }
        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }
    static class Teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities //uygulama boyunca kullanacağımız metodları (ör. validation)static utilities classında toplayabiliriz
    {
        static Utilities()
        {
            //static bir nesnede mutlaka çalışmasını istediğimiz bir kod bloğu varsa static bir constructor ile yazabiliriz
        }
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager //class static olmayacak
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }
        public void DoSomething2()
        {
            Console.WriteLine("Done2");
        }
    }
}
