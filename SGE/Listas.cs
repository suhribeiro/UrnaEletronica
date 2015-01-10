using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SGE
{
    public class Listas
    {
        FileStream arquivos;                                                             
        StreamReader arquivoLer;                                                        

        private List<Partido> list_Partidos = new List<Partido>();                      // Lista que armazenará os partidos cadastrados
        private List<DepEstadual> list_DepEstadual = new List<DepEstadual>();           // Lista que armazenará os Dep. Estaduais cadastrados
        private List<DepFederal> list_DepFederal = new List<DepFederal>();              // Lista que armazenará os Dep. Federais cadastrados
        private List<Senador> list_Senador = new List<Senador>();                       // Lista que armazenará os Senadores cadastrados
        private List<Governador> list_Governador = new List<Governador>();              // Lista que armazenará os Governadores cadastrados
        private List<Presidente> list_Presidente = new List<Presidente>();              // Lista que armazenará os Presidentes  cadastrados
        private List<Eleitor> list_Eleitor = new List<Eleitor>();                       // Lista que armazenará os Eleitores cadastrados
        public List<string> list_Nulo_D_Est = new List<string>();
        public List<string> list_Nulo_D_Fed = new List<string>();
        public List<string> list_Nulo_Sen = new List<string>();
        public List<string> list_Nulo_Gov = new List<string>();
        public List<string> Nulo_Presidente = new List<string>();
        public List<string> list_Branco_D_Est = new List<string>();
        public List<string> list_Branco_D_Fed = new List<string>();
        public List<string> list_Branco_Sen = new List<string>();
        public List<string> list_Branco_Gov = new List<string>();
        public List<string> Branco_Presidente = new List<string>();



        //Metódos Get e Set
        public List<Partido> List_Partidos
        {
            get { return list_Partidos; }
            set { list_Partidos = value; }
        }

        public List<DepEstadual> List_DepEstadual
        {
            get { return list_DepEstadual; }
            set { list_DepEstadual = value; }
        }

        public List<DepFederal> List_DepFederal
        {
            get { return list_DepFederal; }
            set { list_DepFederal = value; }
        }

        public List<Senador> List_Senador
        {
            get { return list_Senador; }
            set { list_Senador = value; }
        }

        public List<Governador> List_Governador
        {
            get { return list_Governador; }
            set { list_Governador = value; }
        }

        public List<Presidente> List_Presidente
        {
            get { return list_Presidente; }
            set { list_Presidente = value; }
        }

        public List<Eleitor> List_Eleitor
        {
            get { return list_Eleitor; }
            set { list_Eleitor = value; }
        }
       
        //Metódos da classe Lista
        
        public void Carrega_Partidos()                  //Carrega os partidos previamente cadastrados
        {
            /*Limpa a lista de partidos antes de carregar os partidos cadastrados.*/  
            List_Partidos.Clear();
            /*Abre ou cria o arquivo que armazenará os partidos.*/                         
            arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Partido.dll", FileMode.OpenOrCreate); 
            /*Leitura do arquivo que contém os partidos já cadastrados */
            arquivoLer = new StreamReader(arquivos);                                                                        

            /*Variável "line", que armazenará a linha lida do arquivo */
            string line;

            /*Enquanto linha for diferente de "null", leia o arquivo*/
            while ((line = arquivoLer.ReadLine()) != null)
            {
                /*Vetor que armazena as informações de cada linha lida, armazenando em cada posição do vetor o que se encontra entre os separadores ";*/
                string[] info = line.Split(';');

                /*Cria um objeto Partido*/
                Partido partido = new Partido();

                /*Nome do partido recebe a infomação lida,que foi armazenada na posição 0 do vetor*/
                partido.Nome = info[0];
                /*Abreviatura do partido recebe a infomação lida,que foi armazenada na posição 1 do vetor*/
                partido.Abrev = info[1];
                /*Código do partido recebe a infomação lida,que foi armazenada na posição 2 do vetor*/
                partido.Cod = Convert.ToInt16(info[2]);

                /*Adiciona o partido na lista de partidos*/
                list_Partidos.Add(partido);
            }
            //Fim da leitura do arquivo.

            //Ordena a lista de partidos pela Abreviatura*/
            List_Partidos = List_Partidos.OrderBy(x => x.Abrev).ToList();

            //Fecha o arquivo
            arquivos.Close();
            arquivoLer.Close();
        }

        public void Carrega_Dep_Estadual()              //Carrega os deputados estaduais previamente cadastrados
        {
            /*Limpa a lista de deputados estaduais antes de carregar os deputados cadastrados.*/  
            List_DepEstadual.Clear();
            /*Abre ou cria o arquivo que armazenará os deputados estaduais.*/                         
            arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Deputado Estadual.dll", FileMode.OpenOrCreate);
            /*Leitura do arquivo que contém os partidos já cadastrados */
            arquivoLer = new StreamReader(arquivos);

            string line;

            while ((line = arquivoLer.ReadLine()) != null)
            {
                string[] info = line.Split(';');
                DepEstadual estadual = new DepEstadual();
                estadual.Part = new Partido();

                estadual.Nome = info[0];
                estadual.NomeUrna = info[1];
                estadual.Num = Convert.ToInt32(info[2]);
                estadual.Part.Abrev = info[3];
                estadual.Uf = info[4];
                estadual.ContaVotos = info[5];

                List_DepEstadual.Add(estadual);

            }

            arquivos.Close();
            arquivoLer.Close();
        }

        public void Carrega_Dep_Federal()
        {
            List_DepFederal.Clear();
            arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Deputado Federal.dll", FileMode.OpenOrCreate);
            arquivoLer = new StreamReader(arquivos);

            string line;

            while ((line = arquivoLer.ReadLine()) != null)
            {
                string[] info = line.Split(';');
                DepFederal federal = new DepFederal();
                federal.Part = new Partido();

                federal.Nome = info[0];
                federal.NomeUrna = info[1];
                federal.Num = Convert.ToInt32(info[2]);
                federal.Part.Abrev = info[3];
                federal.Uf = info[4];
                federal.ContaVotos = info[5];

                List_DepFederal.Add(federal);

            }

            arquivos.Close();
            arquivoLer.Close();
        }

        public void Carrega_Senador()
        {
            List_Senador.Clear();
            arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Senador.dll", FileMode.OpenOrCreate);
            arquivoLer = new StreamReader(arquivos);

            string line;

            while ((line = arquivoLer.ReadLine()) != null)
            {
                string[] info = line.Split(';');
                Senador senador = new Senador();
                senador.Part = new Partido();

                senador.Nome = info[0];
                senador.NomeUrna = info[1];
                senador.Num = Convert.ToInt32(info[2]);
                senador.Part.Abrev = info[3];
                senador.Uf = info[4];
                senador.Sup1 = info[5];
                senador.Sup2 = info[6];
                senador.ContaVotos = info[7];

                List_Senador.Add(senador);

            }

            arquivos.Close();
            arquivoLer.Close();
        }

        public void Carrega_Governador()
        {
            List_Governador.Clear();
            arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Governador.dll", FileMode.OpenOrCreate);
            arquivoLer = new StreamReader(arquivos);

            string line;

            while ((line = arquivoLer.ReadLine()) != null)
            {
                string[] info = line.Split(';');
                Governador governador = new Governador();
                governador.Part = new Partido();

                governador.Nome = info[0];
                governador.NomeUrna = info[1];
                governador.Num = Convert.ToInt32(info[2]);
                governador.Part.Abrev = info[3];
                governador.Uf = info[4];
                governador.Vice = info[5];
                governador.ContaVotos = info[6];

                List_Governador.Add(governador);
            }

            arquivos.Close();
            arquivoLer.Close();
        }

        public void Carrega_Presidente()
        {
            List_Presidente.Clear();
            arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Presidente.dll", FileMode.OpenOrCreate);
            arquivoLer = new StreamReader(arquivos);

            string line;

            while ((line = arquivoLer.ReadLine()) != null)
            {
                string[] info = line.Split(';');
                Presidente presidente = new Presidente();
                presidente.Part = new Partido();
                presidente.ContaVotos = new string [28];

                presidente.Nome = info[0];
                presidente.NomeUrna = info[1];
                presidente.Num = Convert.ToInt32(info[2]);
                presidente.Part.Abrev = info[3];
                presidente.Vice = info[4];

                int j = 0;

                for (int i = 0; i < info.Count(); i++)
                {
                    if (i >= 5)
                    {
                        presidente.ContaVotos[j] = info[i];
                        j++;
                    }
                    
                }

                List_Presidente.Add(presidente);
            }

            arquivos.Close();
            arquivoLer.Close();
        }
        
        public void Carrega_Eleitor()
        {
            List_Eleitor.Clear();
            arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Eleitor.dll", FileMode.OpenOrCreate);
            arquivoLer = new StreamReader(arquivos);

            string line;

            while ((line = arquivoLer.ReadLine()) != null)
            {
                string[] info = line.Split(';');
                Eleitor eleitor = new Eleitor();
                
                eleitor.Nome = info[0];
                eleitor.Uf = info[1];
                eleitor.Secao = Convert.ToInt16(info[2]);
                eleitor.Titulo = Convert.ToInt64(info[3]);
                eleitor.Zona = Convert.ToInt16(info[4]);
                eleitor.Voto = Convert.ToBoolean(info[5]);

                List_Eleitor.Add(eleitor);
            }

            arquivos.Close();
            arquivoLer.Close();
        }
       
        public void Carrega_Eleitor(Eleitor eleitor)
        {
            List_Eleitor.Clear();
            arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Eleitor.dll", FileMode.OpenOrCreate);
            arquivoLer = new StreamReader(arquivos);

            string line = eleitor.Nome + ";" + eleitor.Uf + ";" + eleitor.Secao.ToString() + ";" + eleitor.Titulo.ToString() + ";" + eleitor.Zona.ToString() + ";" + "False";
            string novaLinha = eleitor.Nome + ";" + eleitor.Uf + ";" + eleitor.Secao.ToString() + ";" + eleitor.Titulo.ToString() + ";" + eleitor.Zona.ToString() + ";" + eleitor.Voto.ToString();
            string texto;

            while ((texto = arquivoLer.ReadLine()) != null)
            {
                if (texto == line)
                {
                    texto = texto.Replace(line, novaLinha);
                }
                string[] info = texto.Split(';');
                eleitor = new Eleitor();

                eleitor.Nome = info[0];
                eleitor.Uf = info[1];
                eleitor.Secao = Convert.ToInt16(info[2]);
                eleitor.Titulo = Convert.ToInt64(info[3]);
                eleitor.Zona = Convert.ToInt16(info[4]);
                eleitor.Voto = Convert.ToBoolean(info[5]);

                list_Eleitor.Add(eleitor);

            }
            arquivos.Close();
            arquivoLer.Close();

            arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Eleitor.dll", FileMode.Create);
            arquivos.Close();

            StreamWriter inserirInfo = new StreamWriter(Directory.GetCurrentDirectory() + "\\Cadastros\\Eleitor.dll", true);
            foreach (var item in list_Eleitor)
            {
                inserirInfo.Write("{0};{1};{2};{3};{4};{5}\n", item.Nome, item.Uf, item.Secao, item.Titulo, item.Zona, item.Voto);
            }
            inserirInfo.Close();

        }    

        public void Carrega_Nulo_Estadual()
        {
            list_Nulo_D_Est.Clear();
            arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Votos Nulos Deputado Estadual.dll", FileMode.OpenOrCreate);
            arquivoLer = new StreamReader(arquivos);

            string line;

            while ((line = arquivoLer.ReadLine()) != null)
            {
                string info = line;
                
                list_Nulo_D_Est.Add(info);

            }

            arquivos.Close();
            arquivoLer.Close();
        }

        public void Carrega_Nulo_Federal()
        {
            list_Nulo_D_Fed.Clear();
            arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Votos Nulos Deputado Federal.dll", FileMode.OpenOrCreate);
            arquivoLer = new StreamReader(arquivos);

            string line;

            while ((line = arquivoLer.ReadLine()) != null)
            {
                string info = line;

                list_Nulo_D_Fed.Add(info);

            }

            arquivos.Close();
            arquivoLer.Close();
        }

        public void Carrega_Nulo_Senador()
        {
            list_Nulo_Sen.Clear();
            arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Votos Nulos Senador.dll", FileMode.OpenOrCreate);
            arquivoLer = new StreamReader(arquivos);

            string line;

            while ((line = arquivoLer.ReadLine()) != null)
            {
                string info = line;

                list_Nulo_Sen.Add(info);

            }

            arquivos.Close();
            arquivoLer.Close();
        }

        public void Carrega_Nulo_Governador()
        {
            list_Nulo_Gov.Clear();
            arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Votos Nulos Governador.dll", FileMode.OpenOrCreate);
            arquivoLer = new StreamReader(arquivos);

            string line;

            while ((line = arquivoLer.ReadLine()) != null)
            {
                string info = line;

                list_Nulo_Gov.Add(info);

            }

            arquivos.Close();
            arquivoLer.Close();
        }

        public void Carrega_Nulo_Presidente()
        {
            Nulo_Presidente.Clear();
            arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Votos Nulos Presidente.dll", FileMode.OpenOrCreate);
            arquivoLer = new StreamReader(arquivos);

            string line;

            while ((line = arquivoLer.ReadLine()) != null)
            {
                string info = line;

                Nulo_Presidente.Add(info);

            }

            arquivos.Close();
            arquivoLer.Close();
        }

        public void Carrega_Branco_Estadual()
        {
            list_Branco_D_Est.Clear();
            arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Votos Brancos Deputado Estadual.dll", FileMode.OpenOrCreate);
            arquivoLer = new StreamReader(arquivos);

            string line;

            while ((line = arquivoLer.ReadLine()) != null)
            {
                string info = line;

                list_Branco_D_Est.Add(info);

            }

            arquivos.Close();
            arquivoLer.Close();
        }

        public void Carrega_Branco_Federal()
        {
            list_Branco_D_Fed.Clear();
            arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Votos Brancos Deputado Federal.dll", FileMode.OpenOrCreate);
            arquivoLer = new StreamReader(arquivos);

            string line;

            while ((line = arquivoLer.ReadLine()) != null)
            {
                string info = line;

                list_Branco_D_Fed.Add(info);

            }

            arquivos.Close();
            arquivoLer.Close();
        }

        public void Carrega_Branco_Senador()
        {
            list_Branco_Sen.Clear();
            arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Votos Brancos Senador.dll", FileMode.OpenOrCreate);
            arquivoLer = new StreamReader(arquivos);

            string line;

            while ((line = arquivoLer.ReadLine()) != null)
            {
                string info = line;

                list_Branco_Sen.Add(info);

            }

            arquivos.Close();
            arquivoLer.Close();
        }

        public void Carrega_Branco_Governador()
        {
            list_Branco_Gov.Clear();
            arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Votos Brancos Governador.dll", FileMode.OpenOrCreate);
            arquivoLer = new StreamReader(arquivos);

            string line;

            while ((line = arquivoLer.ReadLine()) != null)
            {
                string info = line;

                list_Branco_Gov.Add(info);

            }

            arquivos.Close();
            arquivoLer.Close();
        }

        public void Carrega_Branco_Presidente()
        {
            Branco_Presidente.Clear();
            arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Votos Brancos Presidente.dll", FileMode.OpenOrCreate);
            arquivoLer = new StreamReader(arquivos);

            string line;

            while ((line = arquivoLer.ReadLine()) != null)
            {
                string info = line;

                Branco_Presidente.Add(info);

            }

            arquivos.Close();
            arquivoLer.Close();
        }

    }
}
