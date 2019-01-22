using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemoSoyutlama
{
    //Constructor ile inject etme
    class Soyutlama
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new DatabaseLogger());
            customerManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();
            
            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private ILogger _logger;
        public CustomerManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Customer added!");
        }
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
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


    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
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
        //Base class taki consturea değer göndermek için kullanım.
        public PersonManager(string entity) : base(entity)
        {

        }

        public void Add() {
            Console.WriteLine("Added!");
            Message();
        }
    }
}
