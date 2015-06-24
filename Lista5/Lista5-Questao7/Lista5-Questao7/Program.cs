using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 7) Crie um programa em c# que leia nome e pontuação de 10 participantes de um concurso.
 * Apresente um ranking das 3 melhores notas com os nomes dos participantes. 
 * Utilize arrays associativos.
 */

namespace Lista5_Questao7
{
    

    class Program
    {
       
        static void Main(string[] args)
        {
            //array associados
            string[] nomes   = new string[3];
            double[] notas   = new double[3];
            
            //variavies
            int ranking = 3;
            string auxNomes = " ";
            double auxNotas = 0;
            
            //entrada de dados
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Out.Write("\n Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Out.Write(" \n Notas: ");
                notas[i] = double.Parse(Console.ReadLine());


            }
            //determinar as três maiores notas
            //ordernar o vetor raking e mostrar apenas as três primeiras notas
            for (int i = 0; i < notas.Length; i++)
            {
                for (int j = 0; j < notas.Length; j++)
                {
                    //troca
                    if (notas[i] > notas[j])
                    {
                        auxNomes = nomes[i];
                        auxNotas = notas[i];

                        nomes[i] = nomes[j];
                        notas[i] = notas[j];

                        nomes[j] = auxNomes;
                        notas[j] = auxNotas;
                       
                    }
                }
            }


            //exibir apenas os três maiores notas, como estão todos so vetores ordenadoas
            for (int i = 0; i < ranking; i++)
            {
                Console.Write("\n Nome: {0} Nota: {1} Ranking: {2} ",nomes[i],notas[i],(i+1));
            }

            Console.ReadKey();
        }
    }
}
