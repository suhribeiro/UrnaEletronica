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
    public partial class Cadastro_Candidato : Form
    {
        /*Variavel que armazena o caminho do diretorio "Cadastros"*/
        string caminho = Directory.GetCurrentDirectory() + "\\Cadastros";
        /*Variavel que armazena o caminho do diretorio "Img"*/
        string caminhoImg = Directory.GetCurrentDirectory() + "\\Img";
        /*Variavel que irá abrir a caixa para busca de arquivos*/
        OpenFileDialog buscaImg = new OpenFileDialog();
        /*Váriavel usada para manipular o arquivo*/
        FileStream cadastro_Candidato;
        /*Objeto do tipo "Estado"*/
        Estado uf = new Estado();
        /*Objeto do tipo "Lista"*/
        Listas lista = new Listas();
        /*Variavel booleana que indica se o candidato foi encontrado ou não*/
        bool achou;

        /*Construtor da classe*/
        public Cadastro_Candidato()
        {
            InitializeComponent();
            lista.Carrega_Partidos();
            uf.CadastraEstados();
            partidos.Text = lista.List_Partidos[0].Abrev;
            num_Candidato.Text = lista.List_Partidos[0].Cod.ToString();
            num_Candidato.MaxLength = 5;
            
            uf_Lista.Text = uf.estados[0].Sigla;

            foreach (var item in lista.List_Partidos)
            {
                partidos.Items.Add(item.Abrev); 
            }

            foreach (var item in uf.estados)
            {
                uf_Lista.Items.Add(item.Sigla);
            }
        }

        /*Método que limpa os textbox da tela*/
        private void Limpar_TextBox()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)(item)).Text = String.Empty;
                }
            }
            partidos.Text = lista.List_Partidos[0].Abrev;
            num_Candidato.Text = lista.List_Partidos[0].Cod.ToString();
            buscaImg.Reset();
        }

        /*Método que faz a validação e verificação dos campos*/
        private bool Verfica_Campos()
        {
            bool aux = false;
            List<TextBox> textbox = new List<TextBox>();

            foreach ( Control item in this.Controls)
            {
                if (item is TextBox)
                {             
                    textbox.Add( (TextBox) item);
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
                else if(item.Name==num_Candidato.Name)
                {
                    if (cargos.Text == "Deputado Estadual" && item.TextLength != 5)
                    {
                        MessageBox.Show("Preencha o campo " + '"' + "Número" + '"' + "com 5 dígitos!",
                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        num_Candidato.Focus();
                        num_Candidato.SelectionStart = 2;
                        num_Candidato.SelectionLength = 0;
                        aux = true;
                        break;
                    }
                    else if (cargos.Text == "Deputado Federal" && item.TextLength != 4)
                    {
                        MessageBox.Show("Preencha o campo " + '"' + "Número" + '"' + "com 4 dígitos!",
                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        num_Candidato.Focus();
                        num_Candidato.SelectionStart = 2;
                        num_Candidato.SelectionLength = 0;
                        aux = true;
                        break;
                    }
                    else if (cargos.Text == "Senador" && item.TextLength != 3)
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
                else if ((cargos.Text == "Senador" && item.Name == Suplente1.Name && item.TextLength == 0))
                {
                    MessageBox.Show("Preencha o campo " + '"' + "1º Sup" + '"' + "!",
                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Suplente1.Focus();
                    aux = true;
                    break;
                }
                else if ((cargos.Text == "Senador") && (item.Name == Suplente2.Name && item.TextLength == 0))
                {
                    MessageBox.Show("Preencha o campo " + '"' + "2º Sup" + '"' + "!",
             "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Suplente2.Focus();
                    aux = true;
                    break;
                }
                else if ((cargos.Text == "Presidente" || cargos.Text == "Governador") && (item.Name == nome_Vice.Name && item.TextLength == 0))
                {
                    MessageBox.Show("Preencha o campo " + '"' + "Vice" + '"' + "!",
                   "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nome_Vice.Focus();
                    aux = true;
                    break;
                }

                else if (item.Name == caminho_Imagem.Name && item.TextLength == 0)
                {
                    MessageBox.Show("Selecione uma imagem para o candidato!",
                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    aux = true;
                    break;
                }
            }

            return aux;
        }

        /*Evento acionado ao clicar no botão Incluir*/
        private void bt_incluir_Click(object sender, EventArgs e)
        {
            achou = false;

            /*Carrega todas as listas de candidatos*/
            lista.Carrega_Dep_Estadual();
            lista.Carrega_Dep_Federal();
            lista.Carrega_Senador();
            lista.Carrega_Governador();
            lista.Carrega_Presidente();

            /*Verifica na lista referente ao cargo cadastrado se o candidato já existe, caso não exista o candidato é cadastrado*/
            switch (cargos.Text)
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
                        estadual.Imagem = Image.FromFile(buscaImg.FileName);
                    }
                    else
                    {
                        break;
                    }
                    

                    if (lista.List_DepEstadual.Count != 0)
                    {
                        foreach (var item in lista.List_DepEstadual)
                        {
                            if ((item.Nome == estadual.Nome) && (item.NomeUrna == estadual.NomeUrna) && (item.Num == estadual.Num) && (item.Uf == estadual.Uf))
                            {
                                MessageBox.Show("Candidato já cadastrado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                achou = true;
                                break;
                            }
                        }
                    }
                    if (achou == false)
                    {
                        try
                        {
                            if (!Directory.GetCurrentDirectory().Contains((caminhoImg)))
                            {
                                Directory.CreateDirectory(caminhoImg);
                            }
                            estadual.Imagem.Save(caminhoImg + "\\" + num_Candidato.Text +"_"+uf_Lista.Text+".jpg", ImageFormat.Jpeg);

                            cadastro_Candidato = new FileStream(caminho + "\\Deputado Estadual.dll", FileMode.OpenOrCreate);
                            cadastro_Candidato.Close();


                            string[] info = new string[6];

                            info[0] = estadual.Nome;
                            info[1] = estadual.NomeUrna;
                            info[2] = estadual.Num.ToString();
                            info[3] = estadual.Part.Abrev;
                            info[4] = estadual.Uf;
                            info[5] = "0";

                            DialogResult result = MessageBox.Show("Os dados informados estão corretos?", "Confirmação", MessageBoxButtons.YesNo);
                            
                            if (result == DialogResult.Yes)
                            {
                                StreamWriter insereInfo = new StreamWriter(caminho + "\\Deputado Estadual.dll", true);
                                insereInfo.WriteLine("{0};{1};{2};{3};{4};{5}", info[0], info[1], info[2], info[3], info[4], info[5]);
                                insereInfo.Close();
                                MessageBox.Show("Candidato cadastrado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                Limpar_TextBox();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Erro ao cadastrar candidato!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        federal.Imagem = Image.FromFile(buscaImg.FileName);
                    }
                    else
                    {
                        break;
                    }
                    

                    if (lista.List_DepFederal.Count != 0)
                    {
                        foreach (var item in lista.List_DepFederal)
                        {
                            if ((item.Nome == federal.Nome) && (item.NomeUrna == federal.NomeUrna) && (item.Num == federal.Num) && (item.Uf == federal.Uf))
                            {
                                MessageBox.Show("Candidato já cadastrado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                achou = true;
                                break;
                            }
                        }
                    }
                    if (achou == false)
                    {
                        try
                        {
                            if (!Directory.GetCurrentDirectory().Contains((caminhoImg)))
                            {
                                Directory.CreateDirectory(caminhoImg);
                            }
                            federal.Imagem.Save(caminhoImg + "\\" + num_Candidato.Text +"_"+uf_Lista.Text+".jpg", ImageFormat.Jpeg);

                            cadastro_Candidato = new FileStream(caminho + "\\Deputado Federal.dll", FileMode.OpenOrCreate);
                            cadastro_Candidato.Close();


                            string[] info = new string[6];

                            info[0] = federal.Nome;
                            info[1] = federal.NomeUrna;
                            info[2] = federal.Num.ToString();
                            info[3] = federal.Part.Abrev;
                            info[4] = federal.Uf;
                            info[5] = "0";

                            DialogResult result = MessageBox.Show("Os dados informados estão corretos?", "Confirmação", MessageBoxButtons.YesNo);
                            
                            if (result == DialogResult.Yes)
                            {
                                StreamWriter insereInfo = new StreamWriter(caminho + "\\Deputado Federal.dll", true);
                                insereInfo.WriteLine("{0};{1};{2};{3};{4};{5}", info[0], info[1], info[2], info[3], info[4], info[5]);
                                insereInfo.Close();
                                MessageBox.Show("Candidato cadastrado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                Limpar_TextBox();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Erro ao cadastrar candidato!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        senador.Imagem = Image.FromFile(buscaImg.FileName);
                        senador.Sup1 = Suplente1.Text;
                        senador.Sup2 = Suplente2.Text;
                    }
                    else
                    {
                        break;
                    }
                    

                    if (lista.List_Senador.Count != 0)
                    {
                        foreach (var item in lista.List_Senador)
                        {
                            if ((item.Nome == senador.Nome) && (item.NomeUrna == senador.NomeUrna) && (item.Num == senador.Num) && (item.Uf == senador.Uf))
                            {
                                MessageBox.Show("Candidato já cadastrado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                achou = true;
                                break;
                            }
                        }
                    }
                    if (achou == false)
                    {
                        try
                        {
                            if (!Directory.GetCurrentDirectory().Contains((caminhoImg)))
                            {
                                Directory.CreateDirectory(caminhoImg);
                            }
                            senador.Imagem.Save(caminhoImg + "\\" + num_Candidato.Text +"_"+uf_Lista.Text+".jpg", ImageFormat.Jpeg);

                            cadastro_Candidato = new FileStream(caminho + "\\Senador.dll", FileMode.OpenOrCreate);
                            cadastro_Candidato.Close();


                            string[] info = new string[8];

                            info[0] = senador.Nome;
                            info[1] = senador.NomeUrna;
                            info[2] = senador.Num.ToString();
                            info[3] = senador.Part.Abrev;
                            info[4] = senador.Uf;
                            info[5] = senador.Sup1;
                            info[6] = senador.Sup2;
                            info[7] = "0";

                            DialogResult result = MessageBox.Show("Os dados informados estão corretos?", "Confirmação", MessageBoxButtons.YesNo);
                            
                            if (result == DialogResult.Yes)
                            {
                                StreamWriter insereInfo = new StreamWriter(caminho + "\\Senador.dll", true);
                                insereInfo.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7}", info[0], info[1], info[2], info[3], info[4], info[5], info[6], info[7]);
                                insereInfo.Close();
                                MessageBox.Show("Candidato cadastrado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                Limpar_TextBox();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Erro ao cadastrar candidato!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        governador.Imagem = Image.FromFile(buscaImg.FileName);
                        governador.Vice = nome_Vice.Text;
                    }
                    else
                    {
                        break;
                    }
                    

                    if (lista.List_Governador.Count != 0)
                    {
                        foreach (var item in lista.List_Governador)
                        {
                            if ((item.Nome == governador.Nome) && (item.NomeUrna == governador.NomeUrna) && (item.Num == governador.Num) && (item.Uf == governador.Uf))
                            {
                                MessageBox.Show("Candidato já cadastrado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                achou = true;
                                break;
                            }
                        }
                    }
                    if (achou == false)
                    {
                        try
                        {
                            if (!Directory.GetCurrentDirectory().Contains((caminhoImg)))
                            {
                                Directory.CreateDirectory(caminhoImg);
                            }
                            governador.Imagem.Save(caminhoImg + "\\" + num_Candidato.Text +"_"+uf_Lista.Text+".jpg", ImageFormat.Jpeg);

                            cadastro_Candidato = new FileStream(caminho + "\\Governador.dll", FileMode.OpenOrCreate);
                            cadastro_Candidato.Close();


                            string[] info = new string[7];

                            info[0] = governador.Nome;
                            info[1] = governador.NomeUrna;
                            info[2] = governador.Num.ToString();
                            info[3] = governador.Part.Abrev;
                            info[4] = governador.Uf;
                            info[5] = governador.Vice;
                            info[6] = "0";

                            DialogResult result = MessageBox.Show("Os dados informados estão corretos?", "Confirmação", MessageBoxButtons.YesNo);
                            
                            if (result == DialogResult.Yes)
                            {
                                StreamWriter insereInfo = new StreamWriter(caminho + "\\Governador.dll", true);
                                insereInfo.WriteLine("{0};{1};{2};{3};{4};{5};{6};", info[0], info[1], info[2], info[3], info[4], info[5], info[6]);
                                insereInfo.Close();
                                MessageBox.Show("Candidato cadastrado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                Limpar_TextBox();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Erro ao cadastrar candidato!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        presidente.Imagem = Image.FromFile(buscaImg.FileName);
                        presidente.Vice = nome_Vice.Text;
                    }
                    else
                    {
                        break;
                    }
                    

                    if (lista.List_Presidente.Count != 0)
                    {
                        foreach (var item in lista.List_Presidente)
                        {
                            if ((item.Nome == presidente.Nome) && (item.NomeUrna == presidente.NomeUrna) && (item.Num == presidente.Num))
                            {
                                MessageBox.Show("Candidato já cadastrado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                achou = true;
                                break;
                            }
                        }
                    }
                    if (achou == false)
                    {
                        try
                        {
                            if (!Directory.GetCurrentDirectory().Contains((caminhoImg)))
                            {
                                Directory.CreateDirectory(caminhoImg);
                            }
                            presidente.Imagem.Save(caminhoImg + "\\" + num_Candidato.Text +".jpg", ImageFormat.Jpeg);

                            cadastro_Candidato = new FileStream(caminho + "\\Presidente.dll", FileMode.OpenOrCreate);
                            cadastro_Candidato.Close();


                            string[] info = new string[33];

                            info[0] = presidente.Nome;
                            info[1] = presidente.NomeUrna;
                            info[2] = presidente.Num.ToString();
                            info[3] = presidente.Part.Abrev;
                            info[4] = presidente.Vice;

                            DialogResult result = MessageBox.Show("Os dados informados estão corretos?", "Confirmação", MessageBoxButtons.YesNo);
                            
                            if (result == DialogResult.Yes)
                            {
                                StreamWriter insereInfo = new StreamWriter(caminho + "\\Presidente.dll", true);
                                insereInfo.WriteLine("{0};{1};{2};{3};{4};BR_0;SP_0;MG_0;RJ_0;RS_0;BA_0;PR_0;CE_0;PE_0;SC_0;GO_0;MA_0;PB_0;PA_0;ES_0;PI_0;"+
                                    "RN_0;AL_0;MT_0;MS_0;DF_0;SE_0;AM_0;RO_0;AC_0;AP_0;RR_0;TO_0"
                                    , info[0], info[1], info[2], info[3], info[4]);
                                insereInfo.Close();
                                MessageBox.Show("Candidato cadastrado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                Limpar_TextBox();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Erro ao cadastrar candidato!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    break;
            }
        }

        /*Evento que bloqueia a digitação de qualquer caracter no combobox*/
        private void combobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /*Evento que permite apenas as setas para navegação no combobox*/
        private void combobox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
            {
                e.Handled = true;
            }
        }

        /*Método que habilita ou desabilita campos da tela, de acordo com o cargo selecionado*/
        private void cargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cargos.Text)
            {
                case "Deputado Estadual":
                    Limpar_TextBox();
                    label7.Visible = false;
                    nome_Vice.Visible = false;
                    label1sup.Visible = false;
                    Suplente1.Visible = false;
                    label2sup.Visible = false;
                    Suplente2.Visible = false;
                    uf_Lista.Visible = true;
                    label5.Visible = true;
                    num_Candidato.MaxLength = 5;

                    break;

                case "Deputado Federal":
                    Limpar_TextBox();
                    label7.Visible = false;
                    nome_Vice.Visible = false;
                    label1sup.Visible = false;
                    Suplente1.Visible = false;
                    label2sup.Visible = false;
                    Suplente2.Visible = false;
                    uf_Lista.Visible = true;
                    label5.Visible = true;
                    num_Candidato.MaxLength = 4;

                    break;

                case "Senador":
                    Limpar_TextBox();
                    label7.Visible = false;
                    nome_Vice.Visible = false;
                    label1sup.Visible = true;
                    Suplente1.Visible = true;
                    label2sup.Visible = true;
                    Suplente2.Visible = true;
                    uf_Lista.Visible = true;
                    label5.Visible = true;
                    num_Candidato.MaxLength = 3;

                    break;

                case "Governador":
                    Limpar_TextBox();
                    label7.Visible = true;
                    nome_Vice.Visible = true;
                    label1sup.Visible = false;
                    Suplente1.Visible = false;
                    label2sup.Visible = false;
                    Suplente2.Visible = false;
                    uf_Lista.Visible = true;
                    label5.Visible = true;
                    num_Candidato.MaxLength = 2;

                    break;

                case "Presidente":
                    Limpar_TextBox();
                    label7.Visible = true;
                    nome_Vice.Visible = true;
                    label1sup.Visible = false;
                    Suplente1.Visible = false;
                    label2sup.Visible = false;
                    Suplente2.Visible = false;
                    uf_Lista.Visible = false;
                    label5.Visible = false;
                    num_Candidato.MaxLength = 2;

                    break;
            }
        }

        /*Método que insere o codigo (legenda) do partido selecionado no campo "Numero do candidato"*/
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

        /*Evento acionado ao clicar no botão de "Procurar imagem" */
        private void bt_procuraimg_Click(object sender, EventArgs e)
        {
            /*Abre a caixa de busca e armazena o caminho da imagem selecionada*/
            buscaImg.Multiselect = false;
            buscaImg.Filter = "Arquivos de Imagem| *.png; *.bmp; *.jpg; *.gif";
            buscaImg.ShowDialog();
            caminho_Imagem.Text = buscaImg.FileName;
        }

        /*Permite apenas a inserção de letras no campo "Nome"*/
        private void preenche_nomes(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*Permite apenas setas de navegação lateral e bloqueia a exclusão dos numeros de legenda*/
        private void num_Candidato_KeyDown(object sender, KeyEventArgs e)
        {
            if (num_Candidato.SelectionStart < 2 && (e.KeyCode != Keys.Left) && (e.KeyCode != Keys.Right))
            {
                e.Handled = true;
            }
        }

        /*Permite apenas a inserção de numeros no campo "Numero" do candidato*/
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

        /*Evento acionado ao clicar no botão "Cancelar"*/
        private void bt_cancelar_Click_1(object sender, EventArgs e)
        {
            /*Fecha a tela*/
            this.Close();
        }

        /*Evento acionado ao clicar no botão "Limpar"*/
        private void bt_limpar_Click(object sender, EventArgs e)
        {
            /*Chama o método que limpa todos os textbox*/
            Limpar_TextBox();
        }
    }
}
