using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6Questao23
{
    class Program
    {
        static void Main(string[] args)
        {
            //variavel
            int qtd, codigo;
            double precototalnota;

            //leitura
            Console.WriteLine("Inserir Quantidade:");
            qtd = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserir Codigo:");
            codigo = int.Parse(Console.ReadLine());

            //calculos
            if (codigo>=1 && codigo<=10)
            {
                precototalnota = qtd * 10;

                if (precototalnota <= 250)
                {
                    precototalnota -= precototalnota * 0.05;
                    Console.WriteLine("Preco total {0:C}",precototalnota);
                }
                else if (precototalnota>250 && precototalnota<=500)
                {
                    precototalnota -= precototalnota * 0.10;
                    Console.WriteLine("Preco total {0:C}", precototalnota);
                }
                else if (precototalnota>500)
                {
                    precototalnota -= precototalnota * 0.15;
                    Console.WriteLine("Preco total {0:C}", precototalnota);
                }

            }
            else if (codigo>=11 && codigo<=20)
            {
                precototalnota = qtd * 15;

                if (precototalnota <= 250)
                {
                    precototalnota -= precototalnota * 0.05;
                    Console.WriteLine("Preco total {0:C}", precototalnota);
                }
                else if (precototalnota > 250 && precototalnota <= 500)
                {
                    precototalnota -= precototalnota * 0.10;
                    Console.WriteLine("Preco total {0:C}", precototalnota);
                }
                else if (precototalnota > 500)
                {
                    precototalnota -= precototalnota * 0.15;
                    Console.WriteLine("Preco total {0:C}", precototalnota);
                }
            }
            else if (codigo >=21 && codigo <= 30)
            {
                precototalnota = qtd * 20;


                if (precototalnota <= 250)
                {
                    precototalnota -= precototalnota * 0.05;
                    Console.WriteLine("Preco total {0:C}", precototalnota);
                }
                else if (precototalnota > 250 && precototalnota <= 500)
                {
                    precototalnota -= precototalnota * 0.10;
                    Console.WriteLine("Preco total {0:C}", precototalnota);
                }
                else if (precototalnota > 500)
                {
                    precototalnota -= precototalnota * 0.15;
                    Console.WriteLine("Preco total {0:C}", precototalnota);
                }
            }
            else if (codigo >= 31 && codigo <= 40)
            {
                precototalnota = qtd * 30;

                if (precototalnota <= 250)
                {
                    precototalnota -= precototalnota * 0.05;
                    Console.WriteLine("Preco total {0:C}", precototalnota);
                }
                else if (precototalnota > 250 && precototalnota <= 500)
                {
                    precototalnota -= precototalnota * 0.10;
                    Console.WriteLine("Preco total {0:C}", precototalnota);
                }
                else if (precototalnota > 500)
                {
                    precototalnota -= precototalnota * 0.15;
                    Console.WriteLine("Preco total {0:C}", precototalnota);
                }
            }
            Console.ReadKey();
        }
    }
}
