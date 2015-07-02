using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Lista 6 - Extra: Estrutura Condicional
/**
 * 1-Fazer um programa que recebe quatro notas e calcula a média e exibindo a
 * mensagem aprovado ou reprovado! Considerando a média 7
 */
namespace Lista6_Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis da classe
            double pnota, snota, tnota, qnota, media;

            //recebendo a nota
            Console.WriteLine("\n inserir a 1 nota:" );
            pnota = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\n inserir a 2 nota:");
            snota = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\n inserir a 3 nota:");
            tnota = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\n inserir a 4 nota:");
            qnota = Int32.Parse(Console.ReadLine());


            //Calculo
            media = (pnota + snota + tnota + qnota) / 4;

            if (media >= 7)
            {
                Console.WriteLine("\n Aprovado!");
            }
            else
            {
                Console.WriteLine("\n Reprovado");
            }

            Console.ReadKey();
        }
    }
}
