using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6Questao24
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis :::::::::::::::::::::::::::::::::::
            double preco;
            int categoria;
            char situacao;

            //leitura :::::::::::::::::::::::::::::::::::::
            Console.WriteLine("inserir preco: ");
            preco = double.Parse(Console.ReadLine());

            Console.WriteLine("inserir categoria: ");
            categoria = int.Parse(Console.ReadLine());

            Console.WriteLine("inserir situacao: ");
            situacao = char.Parse(Console.ReadLine());

            //calculos ::::::::::::::::::::::::::::::::::::
            switch (categoria)
            {
                case 1:
                    if (preco<=25)
                    {
                        preco += preco * 0.05;
                    }
                    else if (preco>25)
                    {
                        preco += preco * 0.12;
                    }
                    break;
                case 2:
                    if (preco <= 25)
                    {
                        preco += preco * 0.08;
                    }
                    else if (preco > 25)
                    {
                        preco += preco * 0.15;
                    }
                      
                    break;
                case 3:
                    if (preco <= 25)
                    {
                        preco += preco * 0.10;
                    }
                    else if (preco > 25)
                    {
                        preco += preco * 0.18;
                    }
                    break;

                default:
                    break;
            }

            //exibindo resultado :::::::::::::::::::::::::::::::

            if (preco<=50)
            {
                Console.WriteLine("Novo Preco: {0} - Barato",preco);
            }
            else if (preco>50 && preco<=120)
            {
                Console.WriteLine("Novo Preco {0} - Normal ",preco);
            }
            else if (preco > 120)
            {
                Console.WriteLine("Novo Preco {0} - Caro ", preco);
            }


            Console.ReadKey();
        }
    }
}
