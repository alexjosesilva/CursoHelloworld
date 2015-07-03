using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6Questao17
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha;

            Console.WriteLine("Informe a senha: ");
            senha = int.Parse(Console.ReadLine());

            if (senha==4531)
            {
                Console.WriteLine("Permissao de Acesso!");
            }
            else
            {
                Console.WriteLine("Permissao Negada!");
            }

            Console.ReadKey();
        }
    }
}
