using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGE
{
    public class Governador:Candidato
    {
        //Declaração do atributo da classe "Governador"

        private int num;        //Número do candidato (2 caracteres)
        private string vice;    //Vice canditato ao cargo de Governador

        //Declaração da propriedade Get e Set

        public int Num
        {
            get { return this.num; }
            set { this.num = value; }
        }

        public string Vice
        {
            get { return this.vice; }
            set { this.vice = value; }
        }

    }
}
