using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoMilhao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tela de abertura do jogo
             TelaInicial telas = new TelaInicial();
             char opt;    

            do
            {
                //Tela de abertura do jogo    
                telas.telaMenu();
                opt = char.ToLower(char.Parse(Console.ReadLine()));

                //Jogo
                Jogo partida = new Jogo();


                switch (opt)
                {
                    case '1': partida.menuJogo(); break;
                    case '2': telas.tela2(); break;
                    case '3': telas.tela3(); break;
                    case '4': telas.tela4(); break;
                    default:
                        break;  
                }
    

            } while (char.ToLower(opt)!='s');
            //saida do sistema
            

            
        }
    }
}
