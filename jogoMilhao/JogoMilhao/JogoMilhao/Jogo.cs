using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoMilhao
{
    class Jogo
    {

        public Jogo()
        {
                
        }

        //menu do jogo
        public void menuJogo()
        {
            string texto = "";

            texto += "\n -------Tema das Perguntas -----";
            texto += "\n 1 - Biologia";
            texto += "\n 2 - Geografia";
            texto += "\n 3 - Historia";
            texto += "\n 4 - Portugues";
            texto += "\n 5 - Matematica";
            texto += "\n --------------------------- \n";
            
            Console.Write(texto);
            Console.ReadKey();

        }

    }
}
