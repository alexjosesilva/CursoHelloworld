using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6Questao11
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;

            Console.WriteLine("Informe o salario: ");
            salario = double.Parse(Console.ReadLine());


            if (salario <= 300)
            {
                Console.WriteLine("Salario Reajustado: {0:C}", salario + (salario * 0.15));
            }
            else if (salario > 300 && salario <= 600)
            {
                Console.WriteLine("Salario Reajustado: {0:C}", salario + (salario * 0.10));
            }
            else if(salario >600 && salario <= 900)
            {
                Console.WriteLine("Salario Reajustado: {0:C}", salario + (salario * 0.05));
            }
            Console.ReadLine();
        }
    }
}
