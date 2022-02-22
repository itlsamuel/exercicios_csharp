using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia_e_Hora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dh = DateTime.Now;
            int anoAtual = dh.Year;
            int mesAtual = dh.Month;
            int diaAtual = dh.Day;
            string diaDaSemana = dh.DayOfWeek.ToString();
            int horaAtual = dh.Hour;
            int minutoAtual = dh.Minute;
            int segundoAtual = dh.Second;

            Console.WriteLine("O dia e hora eh: {0}", dh);

            Console.WriteLine("Ano Atual: {0}", anoAtual);
            Console.WriteLine("Mes Atual: {0}", mesAtual);
            Console.WriteLine("Dia Atual: {0}", diaAtual);
            Console.WriteLine("Dia da Semana: {0}", diaDaSemana);
            Console.WriteLine("Hora Atual: {0}", horaAtual);
            Console.WriteLine("Minuto Atual: {0}", minutoAtual);
            Console.WriteLine("Segundo Atual: {0}", segundoAtual);

            Console.ReadLine();
        }
    }
}
