using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis....
            int numero1, numero2, numero3;
            double produto;

            //Entrada de Saida....
            Console.Out.Write("Numero 1: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Out.Write("Numero 2: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Out.Write("Numero 3: ");
            numero3 = Convert.ToInt32(Console.ReadLine());

            //multiplicação
            produto = numero1 * numero2 * numero3;
            Console.Out.WriteLine("Produto: " + produto);
            Console.ReadKey();

        }
    }
}
