using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6Questao22
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis....
            int idade;
            double peso;

            //leitura....
            Console.WriteLine("inserir idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("inserir peso: ");
            peso = double.Parse(Console.ReadLine());

            if (idade<=20)
            {
                if (peso<=60)
                {
                    Console.WriteLine("Grupo 9");
                }
                else if (peso>60 && peso <=90)
                {
                    Console.WriteLine("Grupo 8");
                }
                else if (peso > 90)
                {
                    Console.WriteLine("Grupo 7");
                }
            }
            else if (idade>20 && idade <=50)
            {
                if (peso <= 60)
                {
                    Console.WriteLine("Grupo 6");
                }
                else if (peso > 60 && peso <= 90)
                {
                    Console.WriteLine("Grupo 5");
                }
                else if (peso > 90)
                {
                    Console.WriteLine("Grupo 4");
                }
            }
            else if (idade>50)
            {
                if (peso <= 60)
                {
                    Console.WriteLine("Grupo 3");
                }
                else if (peso > 60 && peso <= 90)
                {
                    Console.WriteLine("Grupo 2");
                }
                else if (peso > 90)
                {
                    Console.WriteLine("Grupo 1");
                }
            }
            Console.ReadKey();

        }
    }
}
