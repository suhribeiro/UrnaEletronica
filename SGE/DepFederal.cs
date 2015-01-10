using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGE
{
    public class DepFederal:Candidato
    {
        //Declaração do atributo da classe "Dep Federal"

        private int num;        //Número do candidato (4 caracteres)

        //Declaração da propriedade Get e Set
        public int Num
        {
            get { return this.num; }
            set { this.num = value; }
        }
    }
}
