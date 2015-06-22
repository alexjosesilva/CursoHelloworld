using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//9) Faça um programa que calcule a média de alunos e só pare quando o usuário quiser.
namespace Lista4_Questao9
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis....
            double media, pnota, snota;
            char CONT =' ';

            //:::FOR:::
            /*
            for (int i = 0; CONT!='n'; i++)
            {
                Console.Clear();
                Console.Write("Primeita nota: ");
                pnota = double.Parse(Console.ReadLine());
                Console.Write("Segunda nota: ");
                snota = double.Parse(Console.ReadLine());

                media = (pnota + snota) / 2;
                Console.Out.WriteLine("Media " + media);
                Console.WriteLine("Continuar S/n");
                CONT = char.ToLower(char.Parse(Console.ReadLine()));
            }*/

            //:::WHILE:::
            /*  while(CONT!='n'){

                Console.Clear();
                Console.Write("Primeita nota: ");
                pnota = double.Parse(Console.ReadLine());
                Console.Write("Segunda nota: ");
                snota = double.Parse(Console.ReadLine());

                media = (pnota + snota) / 2;
                Console.Out.WriteLine("Media " + media);
                Console.WriteLine("Continuar S/n");
                CONT = char.ToLower(char.Parse(Console.ReadLine()));

            }*/

            //:::DO WHILW:::
            do{
                Console.Clear();
                Console.Write("Primeita nota: ");
                pnota = double.Parse(Console.ReadLine());
                Console.Write("Segunda nota: ");
                snota = double.Parse(Console.ReadLine());

                media = (pnota + snota) / 2;
                Console.Out.WriteLine("Media " + media);
                Console.WriteLine("Continuar S/n");
                CONT = char.ToLower(char.Parse(Console.ReadLine()));

            }while(CONT!='n');

            Console.WriteLine("Saida....");
            Console.ReadKey();

        }
    }
}
