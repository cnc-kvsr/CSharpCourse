using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customermanager = new CustomerManager();
            customermanager.Logger = new SmsLogger();
            //customermanager.Logger = new DatabaseLogger();
            //customermanager.Logger = new FileLogger();
            customermanager.Add();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer added!");
        }
    }
    
    class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged in database!");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }

    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to sms!");
        }
    }

    interface ILogger
    {
        void Log();
    }
}
