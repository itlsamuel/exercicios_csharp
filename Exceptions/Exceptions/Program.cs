using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 0;

            try
            {
                Console.WriteLine("{0}/{1}={2}", a, b, (a / b));
            }
            catch (Exception)
            {
                Console.WriteLine("Eu peguei a exceção!");
            }

            Console.ReadKey();
        }
    }
}
