namespace SGE
{
    partial class Cadastro_Candidato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Candidato));
            this.label1 = new System.Windows.Forms.Label();
            this.cargos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nome_Candidato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.partidos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.num_Candidato = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uf_Lista = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.caminho_Imagem = new System.Windows.Forms.TextBox();
            this.bt_procuraimg = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nome_Vice = new System.Windows.Forms.TextBox();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_incluir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nome_Urna = new System.Windows.Forms.TextBox();
            this.Suplente1 = new System.Windows.Forms.TextBox();
            this.Suplente2 = new System.Windows.Forms.TextBox();
            this.label1sup = new System.Windows.Forms.Label();
            this.label2sup = new System.Windows.Forms.Label();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cargo";
            // 
            // cargos
            // 
            this.cargos.DropDownHeight = 100;
            this.cargos.IntegralHeight = false;
            this.cargos.Items.AddRange(new object[] {
            "Deputado Estadual",
            "Deputado Federal",
            "Senador",
            "Governador",
            "Presidente"});
            this.cargos.Location = new System.Drawing.Point(83, 23);
            this.cargos.MaxDropDownItems = 10;
            this.cargos.Name = "cargos";
            this.cargos.Size = new System.Drawing.Size(121, 21);
            this.cargos.TabIndex = 0;
            this.cargos.Text = "Deputado Estadual";
            this.cargos.SelectedIndexChanged += new System.EventHandler(this.cargos_SelectedIndexChanged);
            this.cargos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combobox_KeyDown);
            this.cargos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combobox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // nome_Candidato
            // 
            this.nome_Candidato.Location = new System.Drawing.Point(83, 66);
            this.nome_Candidato.Name = "nome_Candidato";
            this.nome_Candidato.Size = new System.Drawing.Size(329, 20);
            this.nome_Candidato.TabIndex = 1;
            this.nome_Candidato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.preenche_nomes);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Partido";
            // 
            // partidos
            // 
            this.partidos.DropDownHeight = 100;
            this.partidos.FormattingEnabled = true;
            this.partidos.IntegralHeight = false;
            this.partidos.Location = new System.Drawing.Point(464, 66);
            this.partidos.MaxDropDownItems = 10;
            this.partidos.Name = "partidos";
            this.partidos.Size = new System.Drawing.Size(63, 21);
            this.partidos.TabIndex = 2;
            this.partidos.SelectedIndexChanged += new System.EventHandler(this.partido_SelectedIndexChanged);
            this.partidos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combobox_KeyDown);
            this.partidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combobox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Número";
            // 
            // num_Candidato
            // 
            this.num_Candidato.Location = new System.Drawing.Point(83, 141);
            this.num_Candidato.Name = "num_Candidato";
            this.num_Candidato.Size = new System.Drawing.Size(65, 20);
            this.num_Candidato.TabIndex = 4;
            this.num_Candidato.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_Candidato_KeyDown);
            this.num_Candidato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.preenche_numero);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "UF";
            // 
            // uf_Lista
            // 
            this.uf_Lista.DropDownHeight = 100;
            this.uf_Lista.FormattingEnabled = true;
            this.uf_Lista.IntegralHeight = false;
            this.uf_Lista.Location = new System.Drawing.Point(292, 141);
            this.uf_Lista.MaxDropDownItems = 10;
            this.uf_Lista.Name = "uf_Lista";
            this.uf_Lista.Size = new System.Drawing.Size(120, 21);
            this.uf_Lista.TabIndex = 5;
            this.uf_Lista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combobox_KeyDown);
            this.uf_Lista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combobox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Imagem";
            // 
            // caminho_Imagem
            // 
            this.caminho_Imagem.Location = new System.Drawing.Point(83, 178);
            this.caminho_Imagem.Name = "caminho_Imagem";
            this.caminho_Imagem.ReadOnly = true;
            this.caminho_Imagem.Size = new System.Drawing.Size(268, 20);
            this.caminho_Imagem.TabIndex = 6;
            // 
            // bt_procuraimg
            // 
            this.bt_procuraimg.Location = new System.Drawing.Point(357, 177);
            this.bt_procuraimg.Name = "bt_procuraimg";
            this.bt_procuraimg.Size = new System.Drawing.Size(75, 20);
            this.bt_procuraimg.TabIndex = 7;
            this.bt_procuraimg.Text = "Procurar";
            this.bt_procuraimg.UseVisualStyleBackColor = true;
            this.bt_procuraimg.Click += new System.EventHandler(this.bt_procuraimg_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Vice";
            this.label7.Visible = false;
            // 
            // nome_Vice
            // 
            this.nome_Vice.Location = new System.Drawing.Point(83, 214);
            this.nome_Vice.Name = "nome_Vice";
            this.nome_Vice.Size = new System.Drawing.Size(268, 20);
            this.nome_Vice.TabIndex = 8;
            this.nome_Vice.Visible = false;
            this.nome_Vice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.preenche_nomes);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(261, 278);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(75, 20);
            this.bt_limpar.TabIndex = 11;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_incluir
            // 
            this.bt_incluir.Location = new System.Drawing.Point(180, 278);
            this.bt_incluir.Name = "bt_incluir";
            this.bt_incluir.Size = new System.Drawing.Size(75, 20);
            this.bt_incluir.TabIndex = 10;
            this.bt_incluir.Text = "Incluir";
            this.bt_incluir.UseVisualStyleBackColor = true;
            this.bt_incluir.Click += new System.EventHandler(this.bt_incluir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 108);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nome na Urna";
            // 
            // nome_Urna
            // 
            this.nome_Urna.Location = new System.Drawing.Point(83, 105);
            this.nome_Urna.Name = "nome_Urna";
            this.nome_Urna.Size = new System.Drawing.Size(329, 20);
            this.nome_Urna.TabIndex = 3;
            this.nome_Urna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.preenche_nomes);
            // 
            // Suplente1
            // 
            this.Suplente1.Location = new System.Drawing.Point(83, 214);
            this.Suplente1.Name = "Suplente1";
            this.Suplente1.Size = new System.Drawing.Size(225, 20);
            this.Suplente1.TabIndex = 8;
            this.Suplente1.Visible = false;
            this.Suplente1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.preenche_nomes);
            // 
            // Suplente2
            // 
            this.Suplente2.Location = new System.Drawing.Point(359, 214);
            this.Suplente2.Name = "Suplente2";
            this.Suplente2.Size = new System.Drawing.Size(226, 20);
            this.Suplente2.TabIndex = 9;
            this.Suplente2.Visible = false;
            this.Suplente2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.preenche_nomes);
            // 
            // label1sup
            // 
            this.label1sup.AutoSize = true;
            this.label1sup.Location = new System.Drawing.Point(38, 217);
            this.label1sup.Name = "label1sup";
            this.label1sup.Size = new System.Drawing.Size(39, 13);
            this.label1sup.TabIndex = 17;
            this.label1sup.Text = "1º Sup";
            this.label1sup.Visible = false;
            // 
            // label2sup
            // 
            this.label2sup.AutoSize = true;
            this.label2sup.Location = new System.Drawing.Point(314, 217);
            this.label2sup.Name = "label2sup";
            this.label2sup.Size = new System.Drawing.Size(39, 13);
            this.label2sup.TabIndex = 9;
            this.label2sup.Text = "2º Sup";
            this.label2sup.Visible = false;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(342, 278);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 20);
            this.bt_cancelar.TabIndex = 18;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click_1);
            // 
            // Cadastro_Candidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 310);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.label2sup);
            this.Controls.Add(this.label1sup);
            this.Controls.Add(this.Suplente2);
            this.Controls.Add(this.Suplente1);
            this.Controls.Add(this.bt_incluir);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.nome_Vice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_procuraimg);
            this.Controls.Add(this.caminho_Imagem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uf_Lista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_Candidato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nome_Urna);
            this.Controls.Add(this.nome_Candidato);
            this.Controls.Add(this.partidos);
            this.Controls.Add(this.cargos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro_Candidato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Candidato";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.preenche_nomes);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cargos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nome_Candidato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox partidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox num_Candidato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox uf_Lista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox caminho_Imagem;
        private System.Windows.Forms.Button bt_procuraimg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nome_Vice;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_incluir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nome_Urna;
        private System.Windows.Forms.TextBox Suplente1;
        private System.Windows.Forms.TextBox Suplente2;
        private System.Windows.Forms.Label label1sup;
        private System.Windows.Forms.Label label2sup;
        private System.Windows.Forms.Button bt_cancelar;
    }
}