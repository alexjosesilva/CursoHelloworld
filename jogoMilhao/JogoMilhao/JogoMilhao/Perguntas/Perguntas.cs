using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoMilhao
{
    class Perguntas
    {
        private string pergunta;
        private string alt1;
        private string alt2;
        private string alt3;
        private string alt4;
        private string resp;

        public string Resp
        {
            get { return resp; }
            set { resp = value; }
        }


        public string Pergunta
        {
            get { return pergunta; }
            set { pergunta = value; }
        }

        public string Alt1
        {
            get { return alt1; }
            set { alt1 = value; }
        }

        public string Alt2
        {
            get { return alt2; }
            set { alt2 = value; }
        }

        public string Alt3
        {
            get { return alt3; }
            set { alt3 = value; }
        }

        public string Alt4
        {
            get { return alt4; }
            set { alt4 = value; }
        }

        public Perguntas()
        {
                
        }

        
        
    }
}
