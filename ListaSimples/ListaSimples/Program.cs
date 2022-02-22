using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> l = new List<string>();
            int TAM;

            l.Add("a"); l.Add("b"); l.Add("c");
            l.Add("d"); l.Add("e"); l.Add("f");
            l.Add("g"); l.Add("h"); l.Add("i");

            TAM = l.Count;

            Console.WriteLine("Terceiro Elemento: {0}", l[2]);

            for (int i = 0; i < TAM; i++)
                Console.Write("Item {0} eh: {1}  ", i, l[i]);
            
            Console.WriteLine("\n");
            l.Insert(1, "z");

            for (int i = 0; i < TAM; i++)
                Console.Write("Item {0} eh: {1}  ", i, l[i]);

            Console.WriteLine("\n");
            l.RemoveAt(2);
            l.Insert(2, "x");

            for (int i = 0; i < TAM; i++)
                Console.Write("Item {0} eh: {1}  ", i, l[i]);

            Console.ReadKey();
        }
    }
}
