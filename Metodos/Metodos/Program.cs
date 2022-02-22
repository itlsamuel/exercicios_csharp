using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        public static float velocidade(float velo, float tempo, float aceleracao)
        {
            return (velo + (tempo * aceleracao));
        }
        public static float distancia(float velo, float tempo, float aceleracao)
        {
            return ((float)(velo * tempo + 0.5 * aceleracao * tempo * tempo));
        }

        static void Main(string[] args)
        {
            float dist;
            float v;

            v = velocidade(100, 10, 25);
            Console.WriteLine(v);
            Console.WriteLine("\n");

            dist = distancia(100, 10, 25);
            Console.WriteLine(dist);

            Console.ReadKey();
        }
    }
}
