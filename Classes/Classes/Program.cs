using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caixa cx = new Caixa();
            double volumeCaixa;
            volumeCaixa = cx.Volume();
            Console.WriteLine(volumeCaixa.ToString());
            Console.ReadKey();
        }
    }
}
