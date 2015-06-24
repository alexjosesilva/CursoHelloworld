using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2) Receba três valores do usuário e os exiba em ordem crescente e, depois, em ordem decrescente (Utilize array para armazenar os valores)
namespace Lista5_Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            int[] array = new int[3];

            //aux = variaveis usada para guarda a maior valor do vetor
            int aux = 0;

            //entrada de dados
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }


            //Exibir o vetor desordenado
            Console.Write("\n Vetor: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Out.Write(array[i]);
            }


            //PROCESSO DE ORDENAÇÃO DE MENOR PARA MAIOR: Selection Sort
            // Primeiro FOR, ele fará com que a variável i percorra o vetor a ser ordenado, mas ela vai 
            // anda uma casa enquanto a variável j percorre o vetor todo, ou seja i percorrerá apenas o tamanho
            // do vetor ja j percorrerá o tamanho do vetor vezes o tamanho do vetor 
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    //aqui ocorre a troca do elemento menor pelo maior
                    if (array[i]<array[j])
                    {
                        aux      =  array[i];
                        array[i] =  array[j];
                        array[j] =  aux;   
                    }
                }
            }

            //Exibir o vetor ordenado do Menor para o Maior
            Console.Write("\n Vetor Ordenador Menor para o Maior: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Out.Write(array[i]);
            }

            //PROCESSO DE ORDENAÇÃO DE Menor PARA MAIOR: Selection Sort
            // Primeiro FOR, ele fará com que a variável i percorra o vetor a ser ordenado, mas ela vai 
            // anda uma casa enquanto a variável j percorre o vetor todo, ou seja i percorrerá apenas o tamanho
            // do vetor ja j percorrerá o tamanho do vetor vezes o tamanho do vetor 
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    //aqui ocorre a troca do elemento maior pelo menor
                    if (array[i] > array[j])
                    {
                        aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }

            //Exibir o vetor ordenado do Menor para o Maior
            Console.Write("\n Vetor Ordenador Maior para o Menor: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Out.Write(array[i]);
            }

            Console.ReadKey();

        }
    }
}
