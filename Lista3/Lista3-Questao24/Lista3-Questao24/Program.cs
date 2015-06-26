using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//conversão de moedas....
namespace Lista3_Questao24
{
    class Program
    {
        const double dolar = 1.80;
        const double alemao = 2.00;
        const double libra = 1.57;

        static void Main(string[] args)
        {
            double dinheiro;

            dinheiro = double.Parse(Console.ReadLine());

            Console.Write("\n Dolar: {0:C} ",dinheiro/dolar);
            Console.Write("\n Alemao: {0:C} ", dinheiro / alemao);
            Console.Write("\n Libra: {0:C} ", dinheiro / libra);

            Console.ReadKey();

        }
    }
}
