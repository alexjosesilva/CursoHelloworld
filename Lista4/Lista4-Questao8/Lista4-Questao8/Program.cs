using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 8) Escrever um algoritmo que gera e escreve os 5 primeiros números perfeitos 
 * e calcula a media dos mesmos. 
 * Um número perfeito é aquele que é igual a soma dos seus divisores. 
 * (Ex.: 6 = 1+2+3; 28= 1+2+4+7+14). 
 */

namespace Lista4_Questao8
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis....
            int divisores = 0;
            int contador = 0;
            int numero,i;

            //:::FOR:::
            for (numero = 1; contador<6; numero++)
            {
                //inicializar divisor....
                divisores = 0;

                //:::FOR:::
                for (i=1; i<numero; i++)
                {
                    //se o resto da divisão.... 
                    if (numero % i == 0)
                    {
                        //somar os divisores do numero
                        divisores = divisores+i; 
                    }

                }//segundo for

                //testar se o numero perfeito
                if (numero == divisores)
                {
                    Console.WriteLine(" "+numero);
                    contador++;
                }
   
            }//primeiro for
            Console.WriteLine("fim");
            Console.ReadKey();
        }
    }
}
