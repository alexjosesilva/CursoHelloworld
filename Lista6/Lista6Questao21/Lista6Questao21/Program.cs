using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6Questao21
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco;
            int procedencia;

            Console.WriteLine("inforne o predo: ");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("inforne a procedencia: ");
            procedencia = int.Parse(Console.ReadLine());

            if (procedencia==1)
            {
                Console.WriteLine("Sul");
            }
            else if (procedencia==2)
            {
                Console.WriteLine("Norte");
            }
            else if (procedencia == 3)
            {
                Console.WriteLine("Leste");
            }
            else if (procedencia == 4)
            {
                Console.WriteLine("Oeste");
            }
            else if (procedencia>=5 && procedencia<=6)
            {
                Console.WriteLine("Nordeste");
            }
            else if (procedencia>=7 && procedencia <=9)
            {
                Console.WriteLine("Sudeste");
            }
            else if (procedencia >=10 && procedencia<=20 )
            {
                Console.WriteLine("Centro-Oeste");
            }
            else if (procedencia > 21 && procedencia<30 )
            {
                Console.WriteLine("Nordeste");
            }
            else
            {
                Console.WriteLine("Erro!");
            }


            Console.ReadLine();

        }
    }
}
