using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 2) Faça um programa que exiba todos os números múltiplos de 5, entre 1000 e 2000
 */
namespace Lista4_Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length=2000;

            Console.Write("Numeros Multiplo de 5: ");
            for (int i = 1000; i < length; i++)
            {
                if (i%5==0)
                {
                    Console.Write(" " + i);
                }
            }
            
            Console.ReadKey();
        }
    }
}
