using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6Questao6
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;

            Console.WriteLine("Informe o salario: ");
            salario = double.Parse(Console.ReadLine());


            if (salario <= 500)
            {
                Console.WriteLine("Salario Reajustado: {0:C}", salario + (salario * 0.30));
            }
            else if (salario > 500)
            {
                Console.WriteLine("Salario Não Reajustado!");
            }

            Console.ReadLine();
        }
    }
}
