using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6Questao18
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Informe a senha: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Maior  de Idade!");
            }
            else
            {
                Console.WriteLine("Menor de Idade!");
            }

            Console.ReadKey();
        }
    }
}
