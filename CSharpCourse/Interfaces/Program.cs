using System;
namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPerson person = new IPerson(); interface new lenemez
            IPerson person = new Customer();  // oluşturulabilir.

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal()
            };

            foreach(var customerDal in customerDals)
            {
                customerDal.Add();
            }

            //InterfacesIntro();
            Console.ReadLine();
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Hamit",
                LastName = "Dogan",
                Address = "Istanbul"
            };

            Student student = new Student
            {
                Id = 1,
                FirstName = "Hamit",
                LastName = "Dogan",
                Departmant = "Engineering"
            };

            manager.Add(customer);
            manager.Add(student);
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }
    }

    // soyut Nesne tek başı hiçbir şey ifade etmez
    // IPerson da tanımlanmış herşeyi hem customer hemde student class ta görebiliriz
    // Sen bir interface si tanımladı isen bunların yer aldığı propertyleri implemente eden classta kullanmak zorundasın
    //
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    //somut nesne: 
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson customer)
        {
            Console.WriteLine(customer.FirstName);
        }
    }
}
