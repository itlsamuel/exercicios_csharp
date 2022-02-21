using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {10, 8, 5, 3, 1};

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("posicao[{0}] = {1}",i, arr[i]);
            }
            Console.WriteLine("\n");

            foreach(int i in arr)
                Console.WriteLine("{0}",i);

            Console.WriteLine("\n");

            foreach (int i in arr)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine("{0}",i);
                }
            }

            Console.ReadLine();
        }
    }
}
