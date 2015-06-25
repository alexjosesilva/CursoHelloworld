using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_Questao15
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double salario, conta1, conta2;

            //entrada
            Console.WriteLine("Informe salario: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe Conta1: ");
            conta1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe Conta2: ");
            conta2 = double.Parse(Console.ReadLine());

            //calculos
            conta1 = conta1 + (conta1 * 0.02);
            conta2 = conta2 + (conta2 * 0.02);

            //saida
            Console.WriteLine("Rateio: " + (salario - (conta1 + conta2)));
            Console.ReadKey();

        }
    }
}
