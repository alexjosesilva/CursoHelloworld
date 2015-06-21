using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6) Elabore um algoritmo que imprima a tabuada de um número qualquer. 

namespace Lista4_Questao6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero,i=0, length=10;

            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("::Tabuada da Multiplicacao::");
            //:::FOR:::
            for ( i = 0; i <= length; i++)
            {
                Console.WriteLine(numero+" X "+i+" ="+(numero*i));
            }

            Console.WriteLine("::Tabuada da Multiplicacao::");
            //:::WHILE:::
            i = 0;
            while (i<=length)
            {
                Console.WriteLine(numero + " X " + i + " =" + (numero * i));
                i++;
            }

            Console.WriteLine("::Tabuada da Multiplicacao::");
            //:::DOWHILE:::
            i = 0;
            do{
                Console.WriteLine(numero + " X " + i + " =" + (numero * i));
                i++;
            } while (i <= length) ;

            //saida
            Console.ReadKey();
        }
    }
}
