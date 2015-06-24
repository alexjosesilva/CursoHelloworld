using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 5) Crie um programa em c# que leia um array de 10 números inteiros e 
 * gere um segundo array (que deve ser impresso), cujas posições pares 
 * são o dobro do vetor original e as ímpares são o triplo. 
 */
namespace Lista5_Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            int[] numero  = new int[10];
            int[] numeroP = new int[10];

            //leitura dos numeros
            for (int i = 0; i < numero.Length; i++)
            {
                numero[i] = int.Parse(Console.ReadLine());
                if (i%2 == 0) //posição PAR
                {   //dobro
                    numeroP[i] = 2 * numero[i];
                }
                else //posição IMPAR
                {   //triplo
                    numeroP[i] = 3 * numero[i];
                }

            }


            //exibição
            Console.Write("\n Vetor: ");
            for (int i = 0; i < numero.Length; i++)
            {
                Console.Write("  " + numeroP[i]);
            }
                
            Console.ReadKey();

        }
    }
}
