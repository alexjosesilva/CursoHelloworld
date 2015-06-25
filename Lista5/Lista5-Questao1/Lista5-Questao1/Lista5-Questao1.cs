using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1) Faça um programa que recebe do usuário quatro números e calcula e
//informa a média desses números. (Tudo deve ser armazenado em array)

namespace Lista5_Questao1 
{
    class Program
   { 
        static void Main(string[] args)
        {
            //variaveis
            int[] array = new int[5];
            double soma = 0;

            //loop
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                soma = soma + array[i];
            }

            //saida
            Console.WriteLine("Soma: " + soma);
            Console.ReadKey();

        }
    }
}
