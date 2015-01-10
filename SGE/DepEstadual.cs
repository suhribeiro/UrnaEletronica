using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGE
{
    public class DepEstadual:Candidato
    {
        //Declaração do atributo da classe "Deputado Estadual"

        private int num;        //Número do candidato (5 caracteres)

        //Declaração da propriedade Get e Set
        public int Num
        {
            get { return this.num; }
            set { this.num = value; }
        }
    }
}
