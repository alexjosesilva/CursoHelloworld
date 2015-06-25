using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Questao 14: Faça um programa que receba o ano do nascimento de uma pessoa e o ano atual, 
 * calcule e mostre:
 * a. idade da pessoa em anos
 * b. idade da pessoa em meses
 * c. idade da pessoa em dias
 * d. idade da pessoa em semanas
 */

namespace Lista3_Questao14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
            int anoN, anoAtual;
            
            //Entrada de dados
            Console.Write("Ano Nascimento: ");
            anoN     = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ano Atual: ");
            anoAtual = Convert.ToInt32(Console.ReadLine());

            //Saida
            Console.WriteLine("Quantidade em anos: " + (anoAtual-anoN) );
            Console.WriteLine("Quantidade em meses: " + (anoAtual - anoN)*12);
            Console.WriteLine("Quantidade em dias: " + (anoAtual - anoN)*365);
            Console.WriteLine("Quantidade em semanas: " + (anoAtual - anoN)*48);

            Console.ReadKey();
        }
    }
}
