using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 6) Construa um programa em c# que leia 2 vetores inteiros de 5 posições e apresente o 
 * conjunto União e o conjunto Intersecção dos vetores. 
 */

namespace Lista5_Questao6
{
    class Program
    {
        static void Main(string[] args)
        {
            //vetores
            int cont;

            int[] conjunto1 = new int[5];
            int[] conjunto2 = new int[5];

            int[] UNIAO       = new int[10];
            int[] INTERSECCAO = new int[10];

            //entrada de dados
            Console.Write("Numeros no vetor1: ");
            for (int i = 0; i < conjunto1.Length; i++)
            {
                conjunto1[i] = int.Parse(Console.ReadLine());   
            }

            //entrada de dados
            Console.Write("Numeros no vetor2: ");
            for (int i = 0; i < conjunto2.Length; i++)
            {
                conjunto2[i] = int.Parse(Console.ReadLine());
            }

            //conjunto UNIAO ::::::::::::::::::::::::::
            //TODOS ELEMENTOS DO CONJUNTO 1 E 2 de tamanhos iguais e com igual numero de elementos 
            //sem numero nulos ou vazios
            for (int i = 0; i < conjunto1.Length; i++)
            {
                UNIAO[i]     = conjunto1[i];
                UNIAO[i + 5] = conjunto2[i];
                
            }

            //conjunto INTERSECÇÃO ::::::::::::::::::::
            //TODOS ELEMENTOS DO CONJUNTO 1 E 2 de tamanhos iguais com igual numero de elementos 
            //sem numero nulos ou vazios
            cont = 0;
            for (int i = 0; i < conjunto1.Length; i++)
            {
                for (int j = 0; j < conjunto2.Length; j++)
                {
                    // se um elemento for comum aos dois conjuntos 
                    if (conjunto1[i]==conjunto2[j])
                    {
                        INTERSECCAO[cont] = conjunto1[i];
                        cont++; //contador do conjunto INTERSECCAO
                    }
                }
            }

            //exibição do conjunto UNIAO
            Console.Write("\n Vetor Uniao");
            for (int i = 0; i < UNIAO.Length; i++)
            {
                Console.Write(" " + UNIAO[i]);
            }
            //exibição do conjunto INTERSECÇÃO
            Console.Write("\n Vetor Interseccao: ");
            for (int i = 0; i < INTERSECCAO.Length; i++)
            {
                if (INTERSECCAO[i]!=0)
                {
                    Console.Write(" " + INTERSECCAO[i]);  
                } 
            }

            Console.ReadKey();
        }
    }
}
