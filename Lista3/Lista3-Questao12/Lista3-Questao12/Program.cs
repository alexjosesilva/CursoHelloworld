using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 *  Questao 12: Pedir o valor do Salario Minimo  e o Valor do Salario de um funcionario. O programa
 *  dever informar quantos salarios minimos um funcionario .
 */
namespace Lista3_Questao12
{
    class Program
    {
        static void Main(string[] args)
        {
           //variaveis:::::::
            double salarioM, salarioF, resultado;

            //entrada::::::::
            Console.Write("Salario Minimo: ");
            salarioM = Convert.ToDouble(Console.ReadLine());
            Console.Write("Salario Salario: ");
            salarioF = Convert.ToDouble(Console.ReadLine());

            //calculo::::::::
            resultado = salarioF / salarioM;

            //saida::::::::::
            Console.WriteLine("REsultado: "+ Math.Round(resultado,2) );
            Console.ReadKey();
                

        }
    }
}
