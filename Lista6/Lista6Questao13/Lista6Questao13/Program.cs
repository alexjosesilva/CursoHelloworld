using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6Questao13
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double preco;

            //ler dados
            preco = double.Parse(Console.ReadLine());

            //condicional
            if (preco<=50)
            {
                preco += preco * 0.05;
            }
            else if(preco>50 && preco<=100)
            {
                preco += preco * 0.10;
            }
            else if (preco>100)
            {
                preco += preco * 15;
            }


            if (preco >= 80)
            {
                Console.WriteLine("Classificação: Barato Preço: {0:C} ",preco);
            }
            else if (preco > 80 && preco <= 120)
            {
                Console.WriteLine("Classificação: Normal Preço: {0:C} ", preco);
            }
            else if (preco > 120 && preco <= 200)
            {
                Console.WriteLine("Classificação: Caro Preço: {0:C} ", preco);
            }
            else if (preco > 200)
            {
                Console.WriteLine("Classificação: Muito Caro Preço: {0:C} ", preco);
            }

            Console.ReadKey();
        }
    }
}
