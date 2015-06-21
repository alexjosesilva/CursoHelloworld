using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//5) A série de Ricci difere da série de Fibonacci porque os dois primeiros termos são fornecidos pelo usuário. 
//Os demais termos são gerados da mesma forma que na série de Fibonacci, isto é, os demais termos são sempre a 
//soma dos dois termos anteriores. Implementar um algoritmo que imprima um total de 5 termos da série de Ricci,
//sendo lidos os dois primeiros termos.

namespace Lista4_Questao5
{
    class Lista4Questao5
    {
        static void Main(string[] args)
        {
            int ptermo, stermo, termo;
            int ntermo = 3;

            Console.Write("Primeiro Termo: ");
            ptermo = int.Parse(Console.ReadLine());

            Console.Write("Primeiro Termo: ");
            stermo = int.Parse(Console.ReadLine());

            //saida dos dois primeiros termos
            Console.WriteLine("[ "+ ptermo +" -"+stermo);

            //saida dos demais
            while (ntermo > 0){

                termo  = ptermo + stermo;
                ptermo = stermo;
                stermo = termo;

                if (termo > 1){
                    Console.Write(termo+"-");
                }
                else{
                    Console.Write(termo);
                }
                ntermo=ntermo-1;

            }//While
            Console.Write(" ]");
            Console.ReadKey();
            
        }
    }
}
