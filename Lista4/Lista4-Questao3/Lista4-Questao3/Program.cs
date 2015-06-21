using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3) Faça um programa que leia 5 valores e no final, informe o seu somatório.

namespace Lista4_Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, soma=0;
            int length = 5;

            /* ::: For :::
             * 
            for (int i = 0; i < length; i++)
            {
                Console.Write("Numero: ");
                numero = int.Parse(Console.ReadLine());
                soma = soma + numero;
            }
            */


            //::: While
            while (length>0)
            {
                Console.Write("Numero: ");
                numero = int.Parse(Console.ReadLine());
                soma = soma + numero;
                length--;
            }

            Console.WriteLine("Resultado: "+soma);
            Console.ReadKey();
        }
    }
}
