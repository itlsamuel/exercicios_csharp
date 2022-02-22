using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string meuDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            bool existe = false;
            bool existe2 = false;
            bool existe3 = false;
            string diretorio = "INSS";
            string[] dirNome = new string[] { "Dir_A", "Dir_B", "Dir_C" };
            string apagar = "Dir_B";
            DateTime criarData;

            Console.WriteLine(meuDesktop); //imprimir caminho do desktop
            Console.WriteLine("\n");

            Environment.CurrentDirectory = meuDesktop;
            existe = Directory.Exists(diretorio);

            if (existe)
                Console.WriteLine("Existe !!");
            else
                Console.WriteLine("Não Existe");
            Console.WriteLine("\n");


            foreach (string s in dirNome)
            {
                existe2 = Directory.Exists(s);
                if (existe2 == false)
                {
                    Directory.CreateDirectory(s); //criar diretorio
                    Console.WriteLine("Diretorio {0} criado com sucesso em {1}", s, Environment.CurrentDirectory);
                }
                else
                    Console.WriteLine("Diretorio {0} existe em {1}", s, Environment.CurrentDirectory);
            }
            Console.WriteLine("\n");


            existe3 = Directory.Exists(apagar);
            if(existe3)
                Directory.Delete(apagar); //deletar direorio

            Console.WriteLine("Direotio {0} foi apagado", apagar);
            Console.WriteLine("\n");

            criarData = Directory.GetCreationTime(diretorio);
            Console.WriteLine("Diretorio {0} foi criado em: {1} ", diretorio, criarData);

            Console.ReadKey();
        }
    }
}
