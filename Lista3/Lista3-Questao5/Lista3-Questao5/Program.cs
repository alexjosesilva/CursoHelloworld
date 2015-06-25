using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Questão 5: Fazer um programa que receba o preço  de um produto, calcule e mostre
 * o novo preço sabendo-se que este sofreu um desconto de 10%
 */


namespace Lista3_Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco;

            preco = Convert.ToDouble(Console.ReadLine());
            preco = preco - (preco * 0.10);

            Console.Out.WriteLine("Novo Preco: " + preco);
            Console.ReadKey();
        }
    }
}
