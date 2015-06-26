using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_Questao21
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //variaveis::::::
            double horastrabalhadas, salariominimo, horasextras, vhoraextra;
            double salarioFinal, salarioBruto;
            double valorhorat;
            double valorhextrat;

            //entrada de dados:::::
            Console.Write("\n Informar horas trabalhadas: ");
            horastrabalhadas = double.Parse(Console.ReadLine());

            Console.Write("\n Informar horas extras trabalhandas: ");
            horasextras = double.Parse(Console.ReadLine());

            Console.Write("\n Informe o valro do Salario Minimo: ");
            salariominimo = double.Parse(Console.ReadLine());

            //calculo do salario final:::::
            valorhorat = salariominimo / 8;
            valorhextrat = salariominimo / 4;

            vhoraextra   = valorhextrat*horasextras;
            salarioBruto = valorhorat*horastrabalhadas;
            salarioFinal = salarioBruto + valorhextrat;

            Console.Write("\n Salario Final: {0:C} ",salarioFinal);
            Console.ReadKey();

        }
    }
}
