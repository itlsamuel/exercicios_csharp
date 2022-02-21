using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 7;
            bool result;

            result = x > 7;

            Console.WriteLine("{0} eh maior que {1} ? resposta: {2}",x,y,result);
            Console.ReadLine();
        }
    }
}
