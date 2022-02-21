using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray01 = new int[] {10, 8, 6, 4, 2};
            /*
                [0] - 10
                [1] - 8
                [2] - 6
                [3] - 4
                [4] - 2
             */
            int num;

            num = intArray01.Length;

            Console.WriteLine("{0},{1},{2},{3},{4} e tamanho = {5}", intArray01[0], intArray01[1], intArray01[2],
                intArray01[3], intArray01[4], num);
            Console.ReadKey();

        }
    }
}
