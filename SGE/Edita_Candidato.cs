using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace SGE
{
    public partial class Edita_Candidato : Form
    {
        string caminho = Directory.GetCurrentDirectory() + "\\Cadastros";
        string caminhoImg = Directory.GetCurrentDirectory() + "\\Img";
        OpenFileDialog buscaImg = new OpenFileDialog();
        FileStream cadastro_Candidato;
        Partido partido = new Partido();
        DepEstadual dep_Estadual = new DepEstadual();
        DepFederal dep_Federal = new DepFederal();
        Senador senador = new Senador();
        Governador governador = new Governador();
        Presidente presidente = new Presidente();
        Estado estado = new Estado();
        Listas lista = new Listas();
        string nomeCand, partCand, nomenaUrna, ufCand, suplen1, suplen2, viceCand;
        int numCand;
        StreamReader arquivo;

        public Edita_Candidato(string cargo, string nome, string partido, string nomeUrna, int num, string uf, string sup1, string sup2, string vice)
        {
            nomeCand = nome;
            partCand = partido;
            nomenaUrna = nomeUrna;
            numCand = num;
            ufCand = uf;
            suplen1 = sup1;
            suplen2 = sup2;
            viceCand = vice;

            InitializeComponent();
            estado.CadastraEstados();
            lista.Carrega_Partidos();

            foreach (var item in estado.estados)
            {
                uf_Lista.Items.Add(item.Sigla);
            }

            foreach (var item in lista.List_Partidos)
            {
                partidos.Items.Add(item.Abrev);
            }

            switch (cargo_Candidato.Text = cargo)
            {
                case "Deputado Estadual":

                    label7.Visible = false;
                    nome_Vice.Visible = false;
                    label1sup.Visible = false;
                    Suplente1.Visible = false;
                    label2sup.Visible = false;
                    Suplente2.Visible = false;
                    uf_Lista.Visible = true;
                    label5.Visible = true;
                    num_Candidato.MaxLength = 5;
                    nome_Candidato.Text = nome;
                    nome_Urna.Text = nomeUrna;
                    partidos.Text = partido;
                    uf_Lista.Text = uf;
                    num_Candidato.Text = num.ToString();
                    img_Candidato.BackgroundImage = dep_Estadual.BuscaImagem(num, uf, cargo);


                    break;

                case "Deputado Federal":

                    label7.Visible = false;
                    nome_Vice.Visible = false;
                    label1sup.Visible = false;
                    Suplente1.Visible = false;
                    label2sup.Visible = false;
                    Suplente2.Visible = false;
                    uf_Lista.Visible = true;
                    label5.Visible = true;
                    num_Candidato.MaxLength = 4;
                    nome_Candidato.Text = nome;
                    nome_Urna.Text = nomeUrna;
                    partidos.Text = partido;
                    uf_Lista.Text = uf;
                    num_Candidato.Text = num.ToString();
                    img_Candidato.BackgroundImage = dep_Estadual.BuscaImagem(num, uf, cargo);

                    break;

                case "Senador":

                    label7.Visible = false;
                    nome_Vice.Visible = false;
                    label1sup.Visible = true;
                    Suplente1.Visible = true;
                    label2sup.Visible = true;
                    Suplente2.Visible = true;
                    uf_Lista.Visible = true;
                    label5.Visible = true;
                    num_Candidato.MaxLength = 3;
                    nome_Candidato.Text = nome;
                    nome_Urna.Text = nomeUrna;
                    partidos.Text = partido;
                    uf_Lista.Text = uf;
                    num_Candidato.Text = num.ToString();
                    Suplente1.Text = sup1;
                    Suplente2.Text = sup2;
                    img_Candidato.BackgroundImage = dep_Estadual.BuscaImagem(num, uf, cargo);

                    break;

                case "Governador":

                    label7.Visible = true;
                    nome_Vice.Visible = true;
                    label1sup.Visible = false;
                    Suplente1.Visible = false;
                    label2sup.Visible = false;
                    Suplente2.Visible = false;
                    uf_Lista.Visible = true;
                    label5.Visible = true;
                    num_Candidato.MaxLength = 2;
                    nome_Candidato.Text = nome;
                    nome_Urna.Text = nomeUrna;
                    partidos.Text = partido;
                    uf_Lista.Text = uf;
                    num_Candidato.Text = num.ToString();
                    nome_Vice.Text = vice;
                    img_Candidato.BackgroundImage = dep_Estadual.BuscaImagem(num, uf, cargo);

                    break;

                case "Presidente":
                    label7.Visible = true;
                    nome_Vice.Visible = true;
                    label1sup.Visible = false;
                    Suplente1.Visible = false;
                    label2sup.Visible = false;
                    Suplente2.Visible = false;
                    uf_Lista.Visible = false;
                    label5.Visible = false;
                    num_Candidato.MaxLength = 2;
                    nome_Candidato.Text = nome;
                    nome_Urna.Text = nomeUrna;
                    partidos.Text = partido;
                    num_Candidato.Text = num.ToString();
                    nome_Vice.Text = vice;
                    img_Candidato.BackgroundImage = dep_Estadual.BuscaImagem(num, uf, cargo);

                    break;
            }
        }

        private bool Verfica_Campos()
        {
            bool aux = false;
            List<TextBox> textbox = new List<TextBox>();

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    textbox.Add((TextBox)item);
                }
            }

            textbox = textbox.OrderBy(x => x.TabIndex).ToList();

            foreach (TextBox item in textbox)
            {

                if (item.Name == nome_Candidato.Name && item.TextLength == 0)
                {
                    MessageBox.Show("Preencha o campo " + '"' + "Nome" + '"' + "!",
                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nome_Candidato.Focus();
                    aux = true;
                    break;
                }
                else if (item.Name == nome_Urna.Name && item.TextLength == 0)
                {
                    MessageBox.Show("Preencha o campo " + '"' + "Nome na Urna" + '"' + "!",
                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nome_Urna.Focus();
                    aux = true;
                    break;
                }
                else if (item.Name == num_Candidato.Name)
                {
                    if (cargo_Candidato.Text == "Deputado Estadual" && item.TextLength != 5)
                    {
                        MessageBox.Show("Preencha o campo " + '"' + "Número" + '"' + "com 5 dígitos!",
                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        num_Candidato.Focus();
                        num_Candidato.SelectionStart = 2;
                        num_Candidato.SelectionLength = 0;
                        aux = true;
                        break;
                    }
                    else if (cargo_Candidato.Text == "Deputado Federal" && item.TextLength != 4)
                    {
                        MessageBox.Show("Preencha o campo " + '"' + "Número" + '"' + "com 4 dígitos!",
                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        num_Candidato.Focus();
                        num_Candidato.SelectionStart = 2;
                        num_Candidato.SelectionLength = 0;
                        aux = true;
                        break;
                    }
                    else if (cargo_Candidato.Text == "Senador" && item.TextLength != 3)
                    {
                        MessageBox.Show("Preencha o campo " + '"' + "Número" + '"' + "com 3 dígitos!",
                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        num_Candidato.Focus();
                        num_Candidato.SelectionStart = 2;
                        num_Candidato.SelectionLength = 0;
                        aux = true;
                        break;

                    }
                }
                else if ((cargo_Candidato.Text == "Senador" && item.Name == Suplente1.Name && item.TextLength == 0))
                {
                    MessageBox.Show("Preencha o campo " + '"' + "1º Sup" + '"' + "!",
                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Suplente1.Focus();
                    aux = true;
                    break;
                }
                else if ((cargo_Candidato.Text == "Senador") && (item.Name == Suplente2.Name && item.TextLength == 0))
                {
                    MessageBox.Show("Preencha o campo " + '"' + "2º Sup" + '"' + "!",
             "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Suplente2.Focus();
                    aux = true;
                    break;
                }
                else if ((cargo_Candidato.Text == "Presidente" || cargo_Candidato.Text == "Governador") && (item.Name == nome_Vice.Name && item.TextLength == 0))
                {
                    MessageBox.Show("Preencha o campo " + '"' + "Vice" + '"' + "!",
                   "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nome_Vice.Focus();
                    aux = true;
                    break;
                }
            }

            return aux;
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {

            lista.Carrega_Dep_Estadual();
            lista.Carrega_Dep_Federal();
            lista.Carrega_Senador();
            lista.Carrega_Governador();
            lista.Carrega_Presidente();

            switch (cargo_Candidato.Text)
            {
                case "Deputado Estadual":

                    DepEstadual estadual = new DepEstadual();
                    estadual.Part = new Partido();

                    if (Verfica_Campos() == false)
                    {
                        estadual.Nome = nome_Candidato.Text;
                        estadual.NomeUrna = nome_Urna.Text;
                        estadual.Num = Convert.ToInt32(num_Candidato.Text);
                        estadual.Part.Abrev = partidos.Text;
                        estadual.Uf = uf_Lista.Text;
                        estadual.Imagem = img_Candidato.BackgroundImage;
                    }
                    else
                    {
                        break;
                    }

                    foreach (var item in lista.List_DepEstadual)
                    {
                        if (item.Uf == ufCand && item.Num == numCand)
                        {
                            if (((item.Nome == nome_Candidato.Text) && (item.NomeUrna == nome_Urna.Text) && (item.Num.ToString() == num_Candidato.Text) && (item.Uf == uf_Lista.Text) && (item.Part.Abrev == partidos.Text)) && buscaImg.FileName == null)
                            {
                                MessageBox.Show("Você não alterou nada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                                break;
                            }
                            else
                            {

                                try
                                {
                                    Image.FromFile(buscaImg.FileName).Dispose();

                                    File.Delete(caminhoImg + "\\" + numCand + "_" + ufCand + ".jpg");

                                    estadual.Imagem.Save(caminhoImg + "\\" + num_Candidato.Text + "_" + uf_Lista.Text + ".jpg", ImageFormat.Jpeg);

                                    cadastro_Candidato = new FileStream(caminho + "\\Deputado Estadual.dll", FileMode.OpenOrCreate);

                                    arquivo = new StreamReader(cadastro_Candidato);

                                    string texto;

                                    string linha = item.Nome + ";" + item.NomeUrna + ";" + item.Num.ToString() + ";" + item.Part.Abrev + ";" + item.Uf + ";" + item.ContaVotos;

                                    item.Nome = estadual.Nome;
                                    item.NomeUrna = estadual.NomeUrna;
                                    item.Num = estadual.Num;
                                    item.Part.Abrev = estadual.Part.Abrev;
                                    item.Uf = estadual.Uf;
                                    item.ContaVotos = "0";

                                    string novalinha = item.Nome + ";" + item.NomeUrna + ";" + item.Num.ToString() + ";" + item.Part.Abrev + ";" + item.Uf + ";" + item.ContaVotos;

                                    while ((texto = arquivo.ReadLine()) != null)
                                    {
                                        if (texto == linha)
                                        {
                                            texto = texto.Replace(linha, novalinha);
                                        }
                                    }

                                    arquivo.Close();
                                    cadastro_Candidato.Close();

                                    cadastro_Candidato = new FileStream(caminho + "\\Deputado Estadual.dll", FileMode.Create);
                                    cadastro_Candidato.Close();

                                    StreamWriter insereInfo = new StreamWriter(caminho + "\\Deputado Estadual.dll", true);

                                    foreach (var x in lista.List_DepEstadual)
                                    {
                                        insereInfo.WriteLine("{0};{1};{2};{3};{4};0", x.Nome, x.NomeUrna, x.Num.ToString(), x.Part.Abrev, x.Uf);
                                    }

                                    insereInfo.Close();
                                    MessageBox.Show("Candidato editado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    this.Close();
                                    break;
                                }
                                catch
                                {
                                    MessageBox.Show("Erro ao editar candidato!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    arquivo.Close();
                                    cadastro_Candidato.Close();
                                }
                                break;
                            }
                        }
                    }

                    break;

                case "Deputado Federal":

                    DepFederal federal = new DepFederal();
                    federal.Part = new Partido();

                    if (Verfica_Campos() == false)
                    {
                        federal.Nome = nome_Candidato.Text;
                        federal.NomeUrna = nome_Urna.Text;
                        federal.Num = Convert.ToInt32(num_Candidato.Text);
                        federal.Part.Abrev = partidos.Text;
                        federal.Uf = uf_Lista.Text;
                        federal.Imagem = img_Candidato.BackgroundImage;
                    }
                    else
                    {
                        break;
                    }


                    foreach (var item in lista.List_DepFederal)
                    {
                        if (item.Uf == ufCand && item.Num == numCand)
                        {
                            if ((item.Nome == nome_Candidato.Text) && (item.NomeUrna == nome_Urna.Text) && (item.Num.ToString() == num_Candidato.Text) && (item.Uf == uf_Lista.Text) && (item.Part.Abrev == partidos.Text))
                            {
                                MessageBox.Show("Você não alterou nada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                                break;
                            }
                            else
                            {

                                try
                                {
                                    Image.FromFile(buscaImg.FileName).Dispose();

                                    File.Delete(caminhoImg + "\\" + numCand + "_" + ufCand + ".jpg");

                                    federal.Imagem.Save(caminhoImg + "\\" + num_Candidato.Text + "_" + uf_Lista.Text + ".jpg", ImageFormat.Jpeg);

                                    cadastro_Candidato = new FileStream(caminho + "\\Deputado Federal.dll", FileMode.OpenOrCreate);

                                    StreamReader arquivo = new StreamReader(cadastro_Candidato);

                                    string texto;

                                    string linha = item.Nome + ";" + item.NomeUrna + ";" + item.Num.ToString() + ";" + item.Part.Abrev + ";" + item.Uf + ";" + item.ContaVotos;

                                    item.Nome = federal.Nome;
                                    item.NomeUrna = federal.NomeUrna;
                                    item.Num = federal.Num;
                                    item.Part.Abrev = federal.Part.Abrev;
                                    item.Uf = federal.Uf;
                                    item.ContaVotos = "0";

                                    string novalinha = item.Nome + ";" + item.NomeUrna + ";" + item.Num.ToString() + ";" + item.Part.Abrev + ";" + item.Uf + ";" + item.ContaVotos;

                                    while ((texto = arquivo.ReadLine()) != null)
                                    {
                                        if (texto == linha)
                                        {
                                            texto = texto.Replace(linha, novalinha);
                                        }
                                    }

                                    arquivo.Close();
                                    cadastro_Candidato.Close();

                                    cadastro_Candidato = new FileStream(caminho + "\\Deputado Federal.dll", FileMode.Create);
                                    cadastro_Candidato.Close();

                                    StreamWriter insereInfo = new StreamWriter(caminho + "\\Deputado Federal.dll", true);

                                    foreach (var x in lista.List_DepFederal)
                                    {
                                        insereInfo.WriteLine("{0};{1};{2};{3};{4};0", x.Nome, x.NomeUrna, x.Num.ToString(), x.Part.Abrev, x.Uf);
                                    }

                                    insereInfo.Close();
                                    MessageBox.Show("Candidato editado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    this.Close();
                                    break;
                                }
                                catch
                                {
                                    MessageBox.Show("Erro ao editar candidato!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    arquivo.Close();
                                    cadastro_Candidato.Close();
                                }
                                break;
                            }
                        }
                    }

                    break;

                case "Senador":

                    Senador senador = new Senador();
                    senador.Part = new Partido();

                    if (Verfica_Campos() == false)
                    {
                        senador.Nome = nome_Candidato.Text;
                        senador.NomeUrna = nome_Urna.Text;
                        senador.Num = Convert.ToInt32(num_Candidato.Text);
                        senador.Part.Abrev = partidos.Text;
                        senador.Uf = uf_Lista.Text;
                        senador.Imagem = img_Candidato.BackgroundImage;
                        senador.Sup1 = Suplente1.Text;
                        senador.Sup2 = Suplente2.Text;
                    }
                    else
                    {
                        break;
                    }


                    foreach (var item in lista.List_Senador)
                    {
                        if (item.Uf == ufCand && item.Num == numCand)
                        {
                            if ((item.Nome == nome_Candidato.Text) && (item.NomeUrna == nome_Urna.Text) && (item.Num.ToString() == num_Candidato.Text) && (item.Uf == uf_Lista.Text) && (item.Part.Abrev == partidos.Text) && (item.Sup1 == Suplente1.Text) && (item.Sup2 == Suplente2.Text))
                            {
                                MessageBox.Show("Você não alterou nada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                                break;
                            }
                            else
                            {

                                try
                                {
                                    Image.FromFile(buscaImg.FileName).Dispose();

                                    File.Delete(caminhoImg + "\\" + numCand + "_" + ufCand + ".jpg");

                                    senador.Imagem.Save(caminhoImg + "\\" + num_Candidato.Text + "_" + uf_Lista.Text + ".jpg", ImageFormat.Jpeg);

                                    cadastro_Candidato = new FileStream(caminho + "\\Senador.dll", FileMode.OpenOrCreate);

                                    StreamReader arquivo = new StreamReader(cadastro_Candidato);

                                    string texto;

                                    string linha = item.Nome + ";" + item.NomeUrna + ";" + item.Num.ToString() + ";" + item.Part.Abrev + ";" + item.Uf + ";" + item.Sup1 + ";" + item.Sup2 + ";" + item.ContaVotos;

                                    item.Nome = senador.Nome;
                                    item.NomeUrna = senador.NomeUrna;
                                    item.Num = senador.Num;
                                    item.Part.Abrev = senador.Part.Abrev;
                                    item.Uf = senador.Uf;
                                    item.Sup1 = senador.Sup1;
                                    item.Sup2 = senador.Sup2;
                                    item.ContaVotos = "0";

                                    string novalinha = item.Nome + ";" + item.NomeUrna + ";" + item.Num.ToString() + ";" + item.Part.Abrev + ";" + item.Uf + ";" + item.Sup1 + ";" + item.Sup2 + ";" + item.ContaVotos;

                                    while ((texto = arquivo.ReadLine()) != null)
                                    {
                                        if (texto == linha)
                                        {
                                            texto = texto.Replace(linha, novalinha);
                                        }
                                    }

                                    arquivo.Close();
                                    cadastro_Candidato.Close();

                                    cadastro_Candidato = new FileStream(caminho + "\\Senador.dll", FileMode.Create);
                                    cadastro_Candidato.Close();

                                    StreamWriter insereInfo = new StreamWriter(caminho + "\\Senador.dll", true);

                                    foreach (var x in lista.List_Senador)
                                    {
                                        insereInfo.WriteLine("{0};{1};{2};{3};{4};{5};{6};0", x.Nome, x.NomeUrna, x.Num.ToString(), x.Part.Abrev, x.Uf, x.Sup1, x.Sup2);
                                    }

                                    insereInfo.Close();
                                    MessageBox.Show("Candidato editado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    this.Close();
                                    break;
                                }
                                catch
                                {
                                    MessageBox.Show("Erro ao editar candidato!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    arquivo.Close();
                                    cadastro_Candidato.Close();
                                }
                                break;
                            }
                        }
                    }

                    break;

                case "Governador":

                    Governador governador = new Governador();
                    governador.Part = new Partido();

                    if (Verfica_Campos() == false)
                    {
                        governador.Nome = nome_Candidato.Text;
                        governador.NomeUrna = nome_Urna.Text;
                        governador.Num = Convert.ToInt32(num_Candidato.Text);
                        governador.Part.Abrev = partidos.Text;
                        governador.Uf = uf_Lista.Text;
                        governador.Imagem = img_Candidato.BackgroundImage;
                        governador.Vice = nome_Vice.Text;
                    }
                    else
                    {
                        break;
                    }


                    foreach (var item in lista.List_Governador)
                    {
                        if (item.Uf == ufCand && item.Num == numCand)
                        {
                            if ((item.Nome == nome_Candidato.Text) && (item.NomeUrna == nome_Urna.Text) && (item.Num.ToString() == num_Candidato.Text) && (item.Uf == uf_Lista.Text) && (item.Part.Abrev == partidos.Text) && (item.Vice == nome_Vice.Text))
                            {
                                MessageBox.Show("Você não alterou nada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                                break;
                            }
                            else
                            {

                                try
                                {
                                    Image.FromFile(buscaImg.FileName).Dispose();

                                    File.Delete(caminhoImg + "\\" + numCand + "_" + ufCand + ".jpg");

                                    governador.Imagem.Save(caminhoImg + "\\" + num_Candidato.Text + "_" + uf_Lista.Text + ".jpg", ImageFormat.Jpeg);

                                    cadastro_Candidato = new FileStream(caminho + "\\Governador.dll", FileMode.OpenOrCreate);

                                    StreamReader arquivo = new StreamReader(cadastro_Candidato);

                                    string texto;

                                    string linha = item.Nome + ";" + item.NomeUrna + ";" + item.Num.ToString() + ";" + item.Part.Abrev + ";" + item.Uf + ";" + item.Vice + ";" + item.ContaVotos;

                                    item.Nome = governador.Nome;
                                    item.NomeUrna = governador.NomeUrna;
                                    item.Num = governador.Num;
                                    item.Part.Abrev = governador.Part.Abrev;
                                    item.Uf = governador.Uf;
                                    item.Vice = governador.Vice;
                                    item.ContaVotos = "0";

                                    string novalinha = item.Nome + ";" + item.NomeUrna + ";" + item.Num.ToString() + ";" + item.Part.Abrev + ";" + item.Uf + ";" + item.Vice + ";" + item.ContaVotos;

                                    while ((texto = arquivo.ReadLine()) != null)
                                    {
                                        if (texto == linha)
                                        {
                                            texto = texto.Replace(linha, novalinha);
                                        }
                                    }

                                    arquivo.Close();
                                    cadastro_Candidato.Close();

                                    cadastro_Candidato = new FileStream(caminho + "\\Governador.dll", FileMode.Create);
                                    cadastro_Candidato.Close();

                                    StreamWriter insereInfo = new StreamWriter(caminho + "\\Governador.dll", true);

                                    foreach (var x in lista.List_Governador)
                                    {
                                        insereInfo.WriteLine("{0};{1};{2};{3};{4},{5};0", x.Nome, x.NomeUrna, x.Num.ToString(), x.Part.Abrev, x.Uf, x.Vice);
                                    }

                                    insereInfo.Close();
                                    MessageBox.Show("Candidato editado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    this.Close();
                                    break;
                                }
                                catch
                                {
                                    MessageBox.Show("Erro ao editar candidato!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    arquivo.Close();
                                    cadastro_Candidato.Close();
                                }
                                break;
                            }
                        }
                    }

                    break;

                case "Presidente":

                    Presidente presidente = new Presidente();
                    presidente.Part = new Partido();

                    if (Verfica_Campos() == false)
                    {
                        presidente.Nome = nome_Candidato.Text;
                        presidente.NomeUrna = nome_Urna.Text;
                        presidente.Num = Convert.ToInt32(num_Candidato.Text);
                        presidente.Part.Abrev = partidos.Text;
                        presidente.Imagem = img_Candidato.BackgroundImage;
                        presidente.Vice = nome_Vice.Text;
                    }
                    else
                    {
                        break;
                    }


                    foreach (var x in lista.List_Presidente)
                    {
                        if (x.Num == numCand)
                        {
                            if ((x.Nome == nome_Candidato.Text) && (x.NomeUrna == nome_Urna.Text) && (x.Num.ToString() == num_Candidato.Text) && (x.Part.Abrev == partidos.Text) && (x.Vice == nome_Vice.Text))
                            {
                                MessageBox.Show("Você não alterou nada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                                break;
                            }
                            else
                            {

                                try
                                {
                                    Image.FromFile(buscaImg.FileName).Dispose();

                                    File.Delete(caminhoImg + "\\" + numCand + ".jpg");

                                    presidente.Imagem.Save(caminhoImg + "\\" + num_Candidato.Text +".jpg", ImageFormat.Jpeg);

                                    cadastro_Candidato = new FileStream(caminho + "\\Presidente.dll", FileMode.OpenOrCreate);

                                    StreamReader arquivo = new StreamReader(cadastro_Candidato);

                                    string texto;

                                    string linha = x.Nome + ";" + x.NomeUrna + ";" + x.Num.ToString() + ";" + x.Part.Abrev + ";" + x.Vice + ";" + x.ContaVotos[0] + ";" +
                                ";" + x.ContaVotos[1] + ";" + x.ContaVotos[2] + ";" + x.ContaVotos[3] + ";" + x.ContaVotos[4] + ";" + x.ContaVotos[5] + ";" +
                                x.ContaVotos[6] + ";" + x.ContaVotos[7] + ";" + x.ContaVotos[8] + ";" + x.ContaVotos[9] + ";" + x.ContaVotos[10] + ";" +
                                x.ContaVotos[11] + ";" + x.ContaVotos[12] + ";" + x.ContaVotos[13] + ";" + x.ContaVotos[14] + ";" + x.ContaVotos[15] + ";" +
                                x.ContaVotos[16] + ";" + x.ContaVotos[17] + ";" + x.ContaVotos[18] + ";" + x.ContaVotos[19] + ";" + x.ContaVotos[20] + ";" +
                                x.ContaVotos[21] + ";" + x.ContaVotos[22] + ";" + x.ContaVotos[23] + ";" + x.ContaVotos[24] + ";" + x.ContaVotos[25] + ";" +
                                x.ContaVotos[26] + ";" + x.ContaVotos[27];

                                    x.Nome = presidente.Nome;
                                    x.NomeUrna = presidente.NomeUrna;
                                    x.Num = presidente.Num;
                                    x.Part.Abrev = presidente.Part.Abrev;
                                    x.Vice = presidente.Vice;

                                    string novalinha = x.Nome + ";" + x.NomeUrna + ";" + x.Num.ToString() + ";" + x.Part.Abrev +";" + x.Vice
                                        + ";BR_0;SP_0;MG_0;RJ_0;RS_0;BA_0;PR_0;CE_0;PE_0;SC_0;GO_0;MA_0;PB_0;PA_0;ES_0;PI_0;" +
                                    "RN_0;AL_0;MT_0;MS_0;DF_0;SE_0;AM_0;RO_0;AC_0;AP_0;RR_0;TO_0";

                                    while ((texto = arquivo.ReadLine()) != null)
                                    {
                                        if (texto == linha)
                                        {
                                            texto = texto.Replace(linha, novalinha);
                                        }
                                    }

                                    arquivo.Close();
                                    cadastro_Candidato.Close();

                                    cadastro_Candidato = new FileStream(caminho + "\\Governador.dll", FileMode.Create);
                                    cadastro_Candidato.Close();

                                    StreamWriter insereInfo = new StreamWriter(caminho + "\\Governador.dll", true);

                                    foreach (var item in lista.List_Presidente)
                                    {
                                        insereInfo.WriteLine("{0};{1};{2};{3};{4};BR_0;SP_0;MG_0;RJ_0;RS_0;BA_0;PR_0;CE_0;PE_0;SC_0;GO_0;MA_0;PB_0;PA_0;ES_0;PI_0" +
                                    "RN_0;AL_0;MT_0;MS_0;DF_0;SE_0;AM_0;RO_0;AC_0;AP_0;RR_0;TO_0",
                                    item.Nome, item.NomeUrna, item.Num.ToString(), item.Part.Abrev,item.Vice);

                                    }

                                    insereInfo.Close();
                                    MessageBox.Show("Candidato editado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    this.Close();
                                    break;
                                }
                                catch
                                {
                                    MessageBox.Show("Erro ao editar candidato!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    arquivo.Close();
                                    cadastro_Candidato.Close();
                                }
                                break;
                            }
                        }

                    }

                    break;
            }
        }

        private void num_Candidato_KeyDown(object sender, KeyEventArgs e)
        {
            if (num_Candidato.SelectionStart < 2 && (e.KeyCode != Keys.Left) && (e.KeyCode != Keys.Right))
            {
                e.Handled = true;
            }
        }

        private void combobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combobox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
            {
                e.Handled = true;
            }
        }

        private void preenche_numero(object sender, KeyPressEventArgs e)
        {
            if (num_Candidato.SelectionStart < 2 || (num_Candidato.SelectionStart == 2 && e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }

            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void partido_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in lista.List_Partidos)
            {
                if (item.Abrev == partidos.Text)
                {
                    num_Candidato.Text = item.Cod.ToString();
                }
            }
        }

        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_procuraimg_Click(object sender, EventArgs e)
        {
            Bitmap imagem;
            buscaImg.Multiselect = false;
            buscaImg.Filter = "Arquivos de Imagem| *.png; *.bmp; *.jpg; *.gif";
            buscaImg.ShowDialog();
            imagem = new Bitmap(Image.FromFile(buscaImg.FileName));
            img_Candidato.BackgroundImage = imagem;
        }


    }
}
