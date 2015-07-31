using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoMilhao
{
    class Biologia:Perguntas
    {
        List<Biologia> bio = new List<Biologia>();

        public Biologia()
        {
                
        }

        public Biologia(string pergunta, string alt1, string alt2, string alt3, string alt4, string resp)
        {
            this.Pergunta = pergunta;
            this.Resp = resp;
            this.Alt1 = alt1;
            this.Alt2 = alt2;
            this.Alt3 = alt3;
            this.Alt4 = alt4;
        }

        public void listaPerguntas()
        {
            

        }
    }
}
