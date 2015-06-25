using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Questão 6: Um funcionario recebe salario fixo mais 4% de comissão sobre a vendas.
 * Faça um programa que receba o salario fixo de um funcionário e o valor de suas 
 * vendas, calcular e mostrar a comissão e o salario final do funcionario.
 */

namespace Lista3_Questao6
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis..
            double salariofixo, vendas, comissao, salariofinal;
            
            //entrada 
            Console.Write("Salario: ");
            salariofixo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vendas: ");
            vendas      = Convert.ToDouble(Console.ReadLine());

            //calculos
            comissao     = vendas * 0.04;
            salariofinal = salariofixo + comissao;

            //saida
            Console.WriteLine("Salario Final: " + salariofinal);
            Console.WriteLine("Comissao: " + comissao);
                

        }
    }
}
