using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicMathTableConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, m, n;

            Console.Write("Input the number (Table to be calculated) : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the number (How many times it should to be calculated) : ");
            m = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            for (j = 1; j <= m; j++)
            {
                Console.Write("{0} X {1} = {2} \n", n, j, n * j);
            }

            Console.WriteLine("Click enter to exit");
            Console.ReadLine();
        }
    }
}
