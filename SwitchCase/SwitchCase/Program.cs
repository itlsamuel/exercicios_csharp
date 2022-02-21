using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um mes");
            string mes = Console.ReadLine();

            mes = mes.ToLower();

            switch (mes)
            {
                case "janeiro": case "marco": case "maio": case "julho": case "agosto":
                case "outubro": case "desembro":
                    Console.WriteLine("SEU MES TEM 31 DIAS");
                    break;
                case "abril": case "junho": case "setembro": case "novembro":
                    Console.WriteLine("Seu mes tem 30 dias");
                    break;
            }
            Console.ReadKey();
        }
    }
}
