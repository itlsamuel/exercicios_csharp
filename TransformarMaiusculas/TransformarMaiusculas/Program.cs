using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformarMaiusculas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string primeiroNome = "";
            string segundoNome = "";

            Console.WriteLine("qual seu primeiro nome?");
            primeiroNome = Console.ReadLine();
            Console.WriteLine("qual seu segundo nome?");
            segundoNome = Console.ReadLine();

            Console.WriteLine("primeiro nome maiusculo {0} " +
                " e segundo nome minusculo {1}",primeiroNome.ToUpper(), segundoNome.ToLower());
            Console.ReadKey();
        }
    }
}
