using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Questao 13: Faça um programa que calcule e mostre tabuada de um numero digitado pelo usuario
 */
namespace Lista3_Questao13
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.Write("Informe o numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            //tabuada de soma
            for (int i = 0; i < 11; i++){
                Console.WriteLine(i+"+"+numero+"="+(i+numero));
            }

            Console.WriteLine(" ");
            //tabuada de subtração
            for (int i = 0; i < 11; i++){
                Console.WriteLine(i + "-" + numero + "=" + (i - numero));
            }

            Console.WriteLine(" ");
            //tabuada de multiplicação
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i + "x" + numero + "=" + (i * numero));
            }

            Console.WriteLine(" ");
            //tabuada de divisao
            if (numero != 0)
            {
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine(i + "/" + numero + "=" + Math.Round((i/numero),2) );
                }
            }
            else
                Console.WriteLine("Diviao por Zero não é perimitido!");
            

            Console.ReadKey();

        }
    }
}
