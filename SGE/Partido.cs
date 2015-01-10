using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGE
{
    public class Partido
    {
        //Declaração dos atributos da classe "Partido"

        private string nome;        //Nome do partido
        private string abrev;       //Abreviatura 
        private int cod;            //Codigo especifico de cada partido 

        //Declaração das propriedades Get e Set 

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public string Abrev
        {
            get { return this.abrev; }
            set { this.abrev = value; }
        }

        public int Cod 
        {
            get { return this.cod; }
            set { this.cod = value; }
        }
    }
}
