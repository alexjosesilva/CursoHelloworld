using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace JogoMilhao
{
    class TelaInicial
    {
        public TelaInicial()
        {
                
        }

        //Menu principal irá aparecer na tela antes de jogar
        public void telaMenu()
        {
            Console.Clear();
            Console.Out.Write("\n ---------- Show do Milhao ------------");
            Console.Out.Write("\n ----- Projeto MIC-ETEPAM 2015 --------");
            Console.Out.Write("\n --------------------------------------");
            Console.Out.Write("\n 1 - Iniciar ");
            Console.Out.Write("\n 2 - Regras ");
            Console.Out.Write("\n 3 - Ranking ");
            Console.Out.Write("\n 4 - Sobre ");
            Console.Out.Write("\n S - Sair ");
            Console.Out.Write("\n --------------------------------------\n");
            
        }
        
        /* 
         * pedir o nome do jogador
         * Solicitar nome do jagador
         */
        public void tela1()
        {
            Console.Clear();
            Console.Out.Write("\n --------- Novo Jogador --------------");
            Console.Out.Write("Infomre o seu nome: ");
            string nome;
            nome = Console.ReadLine();
            Console.ReadKey();
        }

        //Tela2: Regras
        public void tela2()
        {
            string regras = " ";
            Console.Clear();

            regras += "\n 1 - Jogador";
            regras += "\n 2 - O candidato contava com vários tipos de ajuda:";
            regras += "\n\n * Universitários - Três estudantes de diversas faculdades davam suas respostas à pergunta e cabia ao participante confiar ou não.";
            regras += "\n\n * Placas - Uma pequena plateia levantava placas numeradas, referentes à alternativa correta. Por exemplo, para a terceira alternativa, levantavam a placa de número 3.";
            regras += "\n\n * Pulos - O participante poderia 'pular' a pergunta caso não soubesse a resposta. Poderia utilizar deste recurso até três vezes";
            regras += "\n\n * Cartas - Quatro cartas de baralho eram viradas e o participante escolhia uma. Se tirasse o “Rei”, nenhuma alternativa errada era eliminada. Se tirasse ‘Ás” elimina uma alternativa errada, “2” elimina duas alternativas erradas e “3” elimina todas as três alternativas erradas, restando apenas a correta.";

            Console.Out.Write(regras);
            Console.ReadKey();
        }

        //tela de hancking...
        //Mostar os nomes dos jogadores por ordem crescente
        public void tela3()
        {
            Console.Clear();
            Console.Out.Write("--------- Hanking --------------");
            
            Console.Out.Write("--------------------------------");
            Console.ReadKey();
        }

        //sobre o desenvolvedor do appp
        public void tela4()
        {
            string texto= "";
 
                texto += "\n Projeto de jogo para conclusao do curso HelloWorld 2015.2 ";
                texto += "\n Autoria: Alex Jose Silva";
                texto += "\n Liguagem: C#";
                texto += "\n Data: 31/07/2015";

            Console.Clear();
            Console.Out.Write("\n ------------- Autoria -----------------");
            Console.Out.Write(texto);
            Console.Out.Write("\n --------------------------------------- \n");
            Console.ReadKey();
        }

        
    }
}
