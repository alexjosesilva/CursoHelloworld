using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6Questao12
{
    class Program
    {
        static void Main(string[] args)
        {
            //variavel
            double salario;

            //leitura
            Console.WriteLine("Informe o salario: ");
            salario = double.Parse(Console.ReadLine());

            //calculos
            if (salario <= 350)
            {
                Console.WriteLine("Salario Reajustado: {0:C}", (salario + 100) - (salario * 0.07));
            }
            else if (salario > 350 && salario <= 600)
            {
                Console.WriteLine("Salario Reajustado: {0:C}", (salario + 75) - (salario * 0.07));
            }
            else if (salario > 600 && salario <= 900)
            {
                Console.WriteLine("Salario Reajustado: {0:C}", (salario + 50) - (salario * 0.07));
            }
            else if (salario>900)
            {
                Console.WriteLine("Salario Reajustado: {0:C}", (salario + 35) - (salario * 0.07));
            }
            
            Console.ReadLine();
        }
    }
}
