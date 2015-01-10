using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGE
{
    class Estado
    {
        //Declaração dos atributos da classe "Estado"
        private string nome;        //Nome do estado
        private string sigla;       //Sigla do estado
        private string digVer;     //Digito verificador do estado no titulo de eleitor.

        public List<Estado> estados = new List<Estado>();      //Lista que armazenará os estados

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public string Sigla
        {
            get { return this.sigla; }
            set { this.sigla = value; }
        }

        public List<Eleitor> Eleitores
        {
            get { return this.Eleitores; }
            set { this.Eleitores = value; }
        }

        public string DigVer
        {
            get { return this.digVer; }
            set { this.digVer = value; }
        }

        //Metodo da classe Estado que cadastra todos os estados do Brasil 
 
        public void CadastraEstados()
        {
            //Cadastro de todos os estados brasileiros 

            Estado uf;                       //Objeto estado

            //Cadastros dos estados 
            uf = new Estado();
            uf.nome = "Acre";
            uf.sigla = "AC";
            uf.digVer = "24";
            estados.Add(uf);        //Armazenando o estado Acre

            uf = new Estado();
            uf.nome = "Alagoas";
            uf.sigla = "AL";
            uf.digVer = "17";
            estados.Add(uf);        //Armazenando o estado Alagoas

            uf = new Estado();
            uf.nome = "Amapá";
            uf.sigla = "AP";
            uf.digVer = "25";
            estados.Add(uf);        //Armazenando o estado Amapá

            uf = new Estado();
            uf.nome = "Amazonas";
            uf.sigla = "AM";
            uf.digVer = "22";
            estados.Add(uf);        //Armazenando o estado Amazonas

            uf = new Estado();
            uf.nome = "Bahia";
            uf.sigla = "BA";
            uf.digVer = "05";
            estados.Add(uf);        //Armazenando o estado Bahia

            uf = new Estado();
            uf.nome = "Ceará";
            uf.sigla = "CE";
            uf.digVer = "07";
            estados.Add(uf);        //Armazenando o estado Ceará

            uf = new Estado();
            uf.nome = "Distrito Federal";
            uf.sigla = "DF";
            uf.digVer = "20";
            estados.Add(uf);        //Armazenando o Distrito Federal

            uf = new Estado();
            uf.nome = "Espírito Santo";
            uf.sigla = "ES";
            uf.digVer = "14";
            estados.Add(uf);        //Armazenando o estado Espirito Santo 

            uf = new Estado();
            uf.nome = "Goiás";
            uf.sigla = "GO";
            uf.digVer = "10";
            estados.Add(uf);        //Armazenando o estado Goiás

            uf = new Estado();
            uf.nome = "Maranhão";
            uf.sigla = "MA";
            uf.digVer = "11";
            estados.Add(uf);        //Armazenando o estado Maranhão

            uf = new Estado();
            uf.nome = "Mato Grosso";
            uf.sigla = "MT";
            uf.digVer = "18";
            estados.Add(uf);        //Armazenando o estado Mato Grosso

            uf = new Estado();
            uf.nome = "Mato Grosso do Sul";
            uf.sigla = "MS";
            uf.digVer = "19";
            estados.Add(uf);        //Armazenando o estado Mato Grosso do Sul

            uf = new Estado();
            uf.nome = "Minas Gerais";
            uf.sigla = "MG";
            uf.digVer = "02";
            estados.Add(uf);        //Armazenando o estado Minas Gerais

            uf = new Estado();
            uf.nome = "Paraná";
            uf.sigla = "PR";
            uf.digVer = "06";
            estados.Add(uf);        //Armazenando o estado Paraná

            uf = new Estado();
            uf.nome = "Pará";
            uf.sigla = "PA";
            uf.digVer = "13";
            estados.Add(uf);        //Armazenando o estado Pará

            uf = new Estado();
            uf.nome = "Paraíba";
            uf.sigla = "PB";
            uf.digVer = "12";
            estados.Add(uf);        //Armazenando o estado Paraiba

            uf = new Estado();
            uf.nome = "Pernambuco";
            uf.sigla = "PE";
            uf.digVer = "08";
            estados.Add(uf);        //Armazenando o estado Pernambuco

            uf = new Estado();
            uf.nome = "Piauí";
            uf.sigla = "PI";
            uf.digVer = "15";
            estados.Add(uf);        //Armazenando o estado Piauí

            uf = new Estado();
            uf.nome = "Rio de Janeiro";
            uf.sigla = "RJ";
            uf.digVer = "03";
            estados.Add(uf);        //Armazenando o estado Rio de Janeiro

            uf = new Estado();
            uf.nome = "Rio Grande do Norte";
            uf.sigla = "RN";
            uf.digVer = "16";
            estados.Add(uf);        //Armazenando o estado Rio Grande do Norte

            uf = new Estado();
            uf.nome = "Rio Grande do Sul";
            uf.sigla = "RS";
            uf.digVer = "04";
            estados.Add(uf);        //Armazenando o estado Rio Grande do Sul

            uf = new Estado();
            uf.nome = "Rondonia";
            uf.sigla = "RO";
            uf.digVer = "23";
            estados.Add(uf);        //Armazenando o estado Rondonia 

            uf = new Estado();
            uf.nome = "Roraima";
            uf.sigla = "RR";
            uf.digVer = "26";
            estados.Add(uf);        //Armazenando o estado Roraima

            uf = new Estado();
            uf.nome = "Santa Catarina";
            uf.sigla = "SC";
            uf.digVer = "09";
            estados.Add(uf);        //Armazenando o estado Santa Catarina

            uf = new Estado();
            uf.nome = "Sergipe";
            uf.sigla = "SE";
            uf.digVer = "21";
            estados.Add(uf);        //Armazenando o estado Sergipe

            uf = new Estado();
            uf.nome = "São Paulo";
            uf.sigla = "SP";
            uf.digVer = "01";
            estados.Add(uf);        //Armazenando o estado São Paulo

            uf = new Estado();
            uf.nome = "Tocantins";
            uf.sigla = "TO";
            uf.digVer = "27";
            estados.Add(uf);        //Armazenando o estado Tocantis
        }

       
    }
}
