using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 1) Faça um programa que exiba todos os números ímpares entre 0 e 100.
 */

namespace Lista4_Questao1
{
    class Lista4Questao1
    {
        static void Main(string[] args)
        {
            int length = 100;

            Console.WriteLine("Numeros primos: ");
            for (int i = 0; i < length; i++)
            {
                if (i%2!=0){
                    Console.Write(" "+i);
                }
            }

            Console.ReadKey();
        }
    }
}
