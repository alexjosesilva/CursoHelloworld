using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6Questao10
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis 
            double custoFabrica;

            //leitura 
            Console.WriteLine("Informe o custo Fabrica : ");
            custoFabrica = double.Parse(Console.ReadLine());

            //condicional
            if (custoFabrica <= 12.000)
            {
                Console.WriteLine(" Custo do Consumidor: {0:C}", custoFabrica + (custoFabrica * 0.05));
            }
            else if (custoFabrica > 12.000 && custoFabrica < 25.000)
            {
                Console.WriteLine("Saldo Medio Reajustado: {0:C}", custoFabrica + (custoFabrica * 0.10) + (custoFabrica * 0.15));
            }
            else if (custoFabrica >= 25.000)
            {
                Console.WriteLine("Saldo Medio Reajustado: {0:C}", custoFabrica + (custoFabrica * 0.15) + (custoFabrica * 0.20));
            }
            

            Console.ReadLine();
        }
    }
}
