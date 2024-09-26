using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int k = 1; k <= 99; k++)
            {
                Console.WriteLine($"Мені {k} {DetermineYearWord(k)}");
            }
        }

        static string DetermineYearWord(int k)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            if (k % 10 == 1 && k != 1)
            {
                return "рік";
            }
            else if ((k % 10 >= 2 && k % 10 <= 4) && !(k >= 12 && k <= 14))
            {
                return "роки";
            }
            else
                return "років";
            Console.ReadKey();
            {



            }
        }
    }
}

