using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnikontroll_2
{
    class Program
    {
        //double number_1;
        static void Main(string[] args)
        {
            double total = 0;
            double value = 0;
            double number = 0;

            do
            {
                Console.Write("Enter value: ");
                string number_1 = Console.ReadLine();
                Console.WriteLine();
                
                number = double.Parse(number_1);
                total += number;

            } while (number != -1);

            total += 1;

            Console.WriteLine("total = " + total);
            Console.WriteLine("15 % Gratuity: €" + total * 0.15);
            Console.ReadLine();



        }
    }
}
