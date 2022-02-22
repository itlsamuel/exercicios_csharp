using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char primeiraPalavra;
            ConsoleKeyInfo cki;

            Console.WriteLine("Escreva uma palavra");

            cki = Console.ReadKey;

            primeiraPalavra = cki.KeyChar;

            Console.WriteLine("\n O caracter digitado eh {0}", primeiraPalavra)
        }
    }
}
