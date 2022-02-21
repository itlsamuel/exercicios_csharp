using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "italo";
            string s2 = "samuel";
            string s3 = "andrade";

            string nome1 = s1 + " " + s2;
            string nome2 = string.Concat(s2, " ", s3);

            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.ReadKey();
        }
    }
}
