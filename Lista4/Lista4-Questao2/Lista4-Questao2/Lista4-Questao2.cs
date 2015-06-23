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
            int i;

            //::FOR:::
            Console.Write(" \n Numeros Multiplo de 5: ");
            for (i = 1000; i < length; i++)
            {
                if (i%5==0)
                {
                    Console.Write(" " + i);
                }
            }


            //:::WHILE:::
            Console.Write("\n Numeros Multiplo de 5: ");
            i = 0;
            while (i<length)
            {
                if (i % 5 == 0)
                {
                    Console.Write(" " + i);
                }
                i++;
            }

            //::DO WHILE:::
            Console.Write("\n Numeros Multiplo de 5: ");
            i = 0;
            do{
                if (i % 5 == 0)
                {
                    Console.Write(" " + i);
                }
                i++;

            } while (i != length);


            Console.ReadKey();
        }
    }
}
