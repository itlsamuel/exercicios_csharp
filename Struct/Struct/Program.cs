using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct veiculo
    {
        public string cor;
        public string registro;
        public ushort ano;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            veiculo fiat = new veiculo();
            Console.WriteLine("cor: {0}, registro: {1}, ano: {2}", fiat.cor, fiat.registro, fiat.ano);
            Console.ReadKey();
        }
    }
}
