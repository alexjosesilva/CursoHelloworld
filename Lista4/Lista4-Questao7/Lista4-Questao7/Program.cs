using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 7) Escrever um algoritmo que escreve os números primos até 1000.

namespace Lista4_Questao7
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis do sistema
            int length = 1000;
            int divisor=0;

            //::FOR::
            for (int numero = 2; numero <= length; numero++)
            {
                //inicializar o contador de divisor
                divisor = 0;
                
                //::FOR::
                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        divisor++;
                    }//if
                   
                }//segundo for

                //numero primo so pode ter dois divisores: 1 e ELE mesmo
                if (divisor == 2)
                {
                    Console.Out.Write(" "+numero);
                }//if
                
            }//primeiro for

            Console.ReadKey();

        }//main
    }
}
