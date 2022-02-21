using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;

            if(x > y)
            {
                Console.WriteLine("{0} eh maior que {1}", x, y);
            }
            if(x < y)
            {
                Console.WriteLine("{0} eh menor que {1}", x, y);
            }

            Console.ReadKey();
        }
    }
}
