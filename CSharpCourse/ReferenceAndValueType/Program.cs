using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);


            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" }; //101 ref num
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" }; //102 ref num

            cities2 = cities1; // cities2 nin referansı cities1 in referansıdır. İkiside 101 ref num olur 
            //102 referansı da tutulmayan bir nesne olduğu için garbage collector o referansı uçurucak. .Net bunu yönetir.
            cities1[0] = "istanbul";
            Console.WriteLine(cities2[0]);

            DataTable dataTable = new DataTable();
            DataTable dataTable2 = new DataTable();

            dataTable2 = dataTable; // performans problemi var iki new lenen ifade var ve bunlardan biri uçurulmuş oldu bu referans atama işlemi ile


            classicTryCatch();

            ActionDemo();


            Func<int, int, int> add = Topla;
            
            Console.WriteLine(add(3, 5));

            Func<int> getRandomNumber = delegate()
            {
                Random random = new Random();
                return random.Next(1, 1000);
            };

            Func<int> getRandomNumber2 = () => new Random().Next(1, 1000);
            Console.WriteLine(getRandomNumber2());
            Thread.Sleep(1000);
            Console.WriteLine(getRandomNumber());

            Console.WriteLine(Topla(2,3));

            Console.ReadLine();

        }

        static int Topla(int x, int y)
        {
            return x + y;
        }

        private static void ActionDemo()
        {
            HandleException(() => { Find(); });
        }

        private static void classicTryCatch()
        {
//Exception
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            throw new RecordNotFoundException("record not found");
        }

        private static void HandleException(Action action) // Action parametresiz metod bloğu
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

    }
}
