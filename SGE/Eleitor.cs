using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGE
{
    public class Eleitor
    {
        //Declaração dos atributos da classe "Eleitor"

        private string nome;        //Nome do Eleitor
        private long titulo;        //Número do título do eleitor
        private int zona;           //Zona eleitoral do eleitor
        private int secao;          //Seção eleitoral do eleitor
        private string uf;          //Estado do eleitor 
        private bool voto = false;  //Indica se o eleitor já votou

        //Declaração das propriedades GET e SET da classe

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public long Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }

        public int Zona
        {
            get { return this.zona; }
            set { this.zona = value; }
        }

        public int Secao
        {
            get { return this.secao; }
            set { this.secao = value; }
        }

        public string Uf
        {
            get { return this.uf; }
            set { this.uf = value; }
        }

        public bool Voto
        {
            get { return this.voto; }
            set { this.voto = value; }
        }
    }
}
