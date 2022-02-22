using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alfabeto alf = new Alfabeto('X');
            Alfabeto alf2 = new Alfabeto('Y');

            ArrayList list = new ArrayList();
            list.Add(alf);
            list.Add(alf2);

            CompararAlfabeto ca = new CompararAlfabeto();

            list.Sort(ca);

            foreach(object o in list)
            {
                Alfabeto z = (Alfabeto)o;
                Console.WriteLine("{0}", z.caract);
            }
            Console.ReadKey();
        }
    }
}
