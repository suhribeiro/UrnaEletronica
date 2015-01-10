using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGE
{
    public class Senador : Candidato
    {
        //Declaração do atributo da classe "Senador"

        private int num;        //Número do candidato (3 caracteres)
        private string sup1; //1º suplente ao cargo de Senador
        private string sup2; //2º suplente ao cargo de Senador

        //Declaração da propriedade Get e Set

        public int Num
        {
            get { return this.num; }
            set { this.num = value; }
        }

        public string Sup1
        {
            get { return this.sup1; }
            set { this.sup1 = value; }
        }

        public string Sup2
        {
            get { return this.sup2; }
            set { this.sup2 = value; }
        }
    }
}
