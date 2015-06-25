using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 0)
                Console.Out.WriteLine("Saida: " + 0);
            else
                if (numero < 0)
                    Console.Out.WriteLine("Saida Menor q Zero");
                else
                    Console.Out.WriteLine("Saida Maior q Zero");
            Console.ReadKey();
        }
    }
}
