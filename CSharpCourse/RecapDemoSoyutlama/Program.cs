//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RecapDemoSoyutlama
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            CustomerManager customerManager = new CustomerManager();
//            customerManager.Logger = new DatabaseLogger();
//            customerManager.Add();
//            Console.ReadLine();
//        }
//    }

//    class CustomerManager
//    {
//        //property injanction
//        public ILogger Logger { get; set; }
//        public void Add()
//        {
//            /* Bu şekilde kullanmamak gerekir interfacelerden yararlanmak daha mantıklıdır.
//            DatabaseLogger logger = new DatabaseLogger();
//            logger.Log();
//            */

//            Logger.Log();
//            Console.WriteLine("Customer added!");
//        }
//    }

//    class DatabaseLogger : ILogger
//    {
//        public void Log()
//        {
//            Console.WriteLine("Logged to database!");
//        }
//    }

//    class FileLogger : ILogger
//    {
//        public void Log()
//        {
//            Console.WriteLine("Logged to file!");
//        }
//    }

//    class SmsLogger : ILogger
//    {
//        public void Log()
//        {
//            Console.WriteLine("Logged to sms!");
//        }
//    }

//    interface ILogger
//    {
//        void Log();
//    }
//}
