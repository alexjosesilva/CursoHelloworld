using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Questao 8: Fazer um programa que leia um peso em Kg e calcule e mostra em gramas
 * 
 */
namespace Lista3_Questao8
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso;

            peso = Convert.ToDouble(Console.ReadLine());
            Console.Out.WriteLine("Peso em gramas: " + peso * 1000);
            Console.ReadKey();
        }
    }
}
