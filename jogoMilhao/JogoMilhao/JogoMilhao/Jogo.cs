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
            texto += "\n B - Biologia";
            texto += "\n G - Geografia";
            texto += "\n H - Historia";
            texto += "\n P - Portugues";
            texto += "\n M - Matematica";
            texto += "\n --------------------------- \n";
            
            Console.Write(texto);
            Console.ReadKey();

        }

        

    }
}
