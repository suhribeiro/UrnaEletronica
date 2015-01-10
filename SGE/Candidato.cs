using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace SGE
{
    public abstract class Candidato
    {
        //Declaração dos atributos da classe "Candidato"

        private string nome;        //Nome completo do candito 
        private string nomeUrna;    //Nome exibido na urna
        private Partido part;       //Relacionamento da classe "Candidato" com a classe "Partido" 
        private string uf;          //Estado onde o candidato concorre ao cargo
        private Image imagem;
        private string contaVotos;  //String que armazena a quantidade de votos

        //Declaração das propriedades Get e Set da Classe

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public string NomeUrna
        {
            get { return this.nomeUrna; }
            set { this.nomeUrna = value; }

        }

        public Partido Part
        {
            get { return this.part; }
            set { this.part = value; }
        }

        public string Uf
        {
            get { return this.uf; }
            set { this.uf = value; }
        }

        public Image Imagem
        {
            get { return this.imagem; }
            set { this.imagem = value; }
        }

        public string ContaVotos
        {
            get { return this.contaVotos; }
            set { this.contaVotos = value; }
        }

        //Metodo que retorna a imagem cadastrada, de acordo com o parametros recebidos.
        public Image BuscaImagem(int numC, string UFC, string cargo)
        {
            Bitmap imagemAux;

            if (cargo == "Presidente")
            {
                imagem = Image.FromFile(Directory.GetCurrentDirectory() + "\\img\\" + numC + ".jpg");
                imagemAux = new Bitmap(imagem);
                imagem.Dispose();
                return imagemAux;
            }
            else
            {
                imagem = Image.FromFile(Directory.GetCurrentDirectory() + "\\img\\" + numC + "_" + UFC + ".jpg");
                imagemAux = new Bitmap(imagem);
                imagem.Dispose();
                return imagemAux;
            }
        }

    }
}