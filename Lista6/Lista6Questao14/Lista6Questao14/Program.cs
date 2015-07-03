using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6Questao14
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
            if (salario <= 300)
            {
                Console.WriteLine("Salario Reajustado: {0:C}", salario + (salario * 0.5));
            }
            else if (salario > 300 && salario <= 500)
            {
                Console.WriteLine("Salario Reajustado: {0:C}", salario + (salario * 0.4));
            }
            else if (salario > 500 && salario <= 700)
            {
                Console.WriteLine("Salario Reajustado: {0:C}", salario + (salario * 0.3));
            }
            else if (salario > 700 && salario <= 800)
            {
                Console.WriteLine("Salario Reajustado: {0:C}", salario + (salario * 0.2));
            }
            else if (salario > 800 && salario <= 1000)
            {
                Console.WriteLine("Salario Reajustado: {0:C}", salario + (salario * 0.1));
            }
            else
            {
                Console.WriteLine("Salario Reajustado: {0:C}", salario + (salario * 0.5));
            }
            Console.ReadLine();
        }
    }
}
