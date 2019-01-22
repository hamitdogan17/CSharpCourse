using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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


            Console.ReadLine();

        }
    }
}
