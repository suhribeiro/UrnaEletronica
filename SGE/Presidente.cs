using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGE
{
    public class Presidente:Candidato
    {
        //Declaração dos atributos da classe "Presidente"

        private int num;                    //Número do candidato (2 caracteres)
        private string vice;                //Vice candidato ao cargo de Presidente
        private string [] contaVotos;           //Vetor que armazena a quantidade de votos, sendo uma posição para cada estado;


        //Declaração das propriedades Get e Set

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

        public string [] ContaVotos
        {
            get { return this.contaVotos; }
            set { this.contaVotos = value; }
        }
        
    }
}
