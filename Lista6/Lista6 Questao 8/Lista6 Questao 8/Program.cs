using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6_Questao_8
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
                Console.WriteLine("Salario Reajustado: {0}",300+(300*0.35));
            }
            else if(salario > 300)
            {
                 Console.WriteLine("Salario Reajustado: {0}",300+(300*0.15));
            }

            Console.ReadLine();
        }
    }
}
