using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Questão 7: Fazer um programa  que receba o peso de uma pessoa, calcule e mostre:
 * a. O novo peso se a pessoa engordar 15%  sobre o peso digitado
 * b. O novo peso se a pessoa emagrecer 20%  sobre o peso digitado
 */


namespace Lista3_Questao7
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso;

            Console.Write("Informe o peso: ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Se engordar: "+(peso+(peso*0.15)));
            Console.WriteLine("Se emagrecer: "+(peso-(peso*0.20)));

            Console.ReadKey();
           
        }
    }
}
