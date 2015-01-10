namespace SGE
{
    partial class Edita_Candidato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edita_Candidato));
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.label2sup = new System.Windows.Forms.Label();
            this.label1sup = new System.Windows.Forms.Label();
            this.Suplente2 = new System.Windows.Forms.TextBox();
            this.Suplente1 = new System.Windows.Forms.TextBox();
            this.bt_incluir = new System.Windows.Forms.Button();
            this.nome_Vice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_procuraimg = new System.Windows.Forms.Button();
            this.uf_Lista = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.num_Candidato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nome_Urna = new System.Windows.Forms.TextBox();
            this.nome_Candidato = new System.Windows.Forms.TextBox();
            this.partidos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cargo_Candidato = new System.Windows.Forms.Label();
            this.img_Candidato = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(301, 278);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 20);
            this.bt_cancelar.TabIndex = 42;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // label2sup
            // 
            this.label2sup.AutoSize = true;
            this.label2sup.Location = new System.Drawing.Point(318, 212);
            this.label2sup.Name = "label2sup";
            this.label2sup.Size = new System.Drawing.Size(39, 13);
            this.label2sup.TabIndex = 37;
            this.label2sup.Text = "2º Sup";
            this.label2sup.Visible = false;
            // 
            // label1sup
            // 
            this.label1sup.AutoSize = true;
            this.label1sup.Location = new System.Drawing.Point(42, 212);
            this.label1sup.Name = "label1sup";
            this.label1sup.Size = new System.Drawing.Size(39, 13);
            this.label1sup.TabIndex = 41;
            this.label1sup.Text = "1º Sup";
            this.label1sup.Visible = false;
            // 
            // Suplente2
            // 
            this.Suplente2.Location = new System.Drawing.Point(363, 209);
            this.Suplente2.Name = "Suplente2";
            this.Suplente2.Size = new System.Drawing.Size(226, 20);
            this.Suplente2.TabIndex = 36;
            this.Suplente2.Visible = false;
            this.Suplente2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // Suplente1
            // 
            this.Suplente1.Location = new System.Drawing.Point(87, 209);
            this.Suplente1.Name = "Suplente1";
            this.Suplente1.Size = new System.Drawing.Size(225, 20);
            this.Suplente1.TabIndex = 35;
            this.Suplente1.Visible = false;
            this.Suplente1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // bt_incluir
            // 
            this.bt_incluir.Location = new System.Drawing.Point(220, 278);
            this.bt_incluir.Name = "bt_incluir";
            this.bt_incluir.Size = new System.Drawing.Size(75, 20);
            this.bt_incluir.TabIndex = 38;
            this.bt_incluir.Text = "Salvar";
            this.bt_incluir.UseVisualStyleBackColor = true;
            this.bt_incluir.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // nome_Vice
            // 
            this.nome_Vice.Location = new System.Drawing.Point(87, 172);
            this.nome_Vice.Name = "nome_Vice";
            this.nome_Vice.Size = new System.Drawing.Size(268, 20);
            this.nome_Vice.TabIndex = 34;
            this.nome_Vice.Visible = false;
            this.nome_Vice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Vice";
            this.label7.Visible = false;
            // 
            // bt_procuraimg
            // 
            this.bt_procuraimg.Location = new System.Drawing.Point(462, 158);
            this.bt_procuraimg.Name = "bt_procuraimg";
            this.bt_procuraimg.Size = new System.Drawing.Size(112, 20);
            this.bt_procuraimg.TabIndex = 32;
            this.bt_procuraimg.Text = "Trocar imagem";
            this.bt_procuraimg.UseVisualStyleBackColor = true;
            this.bt_procuraimg.Click += new System.EventHandler(this.bt_procuraimg_Click);
            // 
            // uf_Lista
            // 
            this.uf_Lista.DropDownHeight = 100;
            this.uf_Lista.FormattingEnabled = true;
            this.uf_Lista.IntegralHeight = false;
            this.uf_Lista.Location = new System.Drawing.Point(296, 136);
            this.uf_Lista.MaxDropDownItems = 10;
            this.uf_Lista.Name = "uf_Lista";
            this.uf_Lista.Size = new System.Drawing.Size(120, 21);
            this.uf_Lista.TabIndex = 29;
            this.uf_Lista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combobox_KeyDown);
            this.uf_Lista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combobox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "UF";
            // 
            // num_Candidato
            // 
            this.num_Candidato.Location = new System.Drawing.Point(87, 136);
            this.num_Candidato.Name = "num_Candidato";
            this.num_Candidato.Size = new System.Drawing.Size(65, 20);
            this.num_Candidato.TabIndex = 28;
            this.num_Candidato.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_Candidato_KeyDown);
            this.num_Candidato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.preenche_numero);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Partido";
            // 
            // nome_Urna
            // 
            this.nome_Urna.Location = new System.Drawing.Point(87, 100);
            this.nome_Urna.Name = "nome_Urna";
            this.nome_Urna.Size = new System.Drawing.Size(329, 20);
            this.nome_Urna.TabIndex = 25;
            this.nome_Urna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // nome_Candidato
            // 
            this.nome_Candidato.Location = new System.Drawing.Point(87, 61);
            this.nome_Candidato.Name = "nome_Candidato";
            this.nome_Candidato.Size = new System.Drawing.Size(329, 20);
            this.nome_Candidato.TabIndex = 23;
            this.nome_Candidato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // partidos
            // 
            this.partidos.DropDownHeight = 100;
            this.partidos.FormattingEnabled = true;
            this.partidos.IntegralHeight = false;
            this.partidos.Location = new System.Drawing.Point(353, 18);
            this.partidos.MaxDropDownItems = 10;
            this.partidos.Name = "partidos";
            this.partidos.Size = new System.Drawing.Size(63, 21);
            this.partidos.TabIndex = 24;
            this.partidos.SelectedIndexChanged += new System.EventHandler(this.partido_SelectedIndexChanged);
            this.partidos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combobox_KeyDown);
            this.partidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combobox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 103);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nome na Urna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cargo:";
            // 
            // cargo_Candidato
            // 
            this.cargo_Candidato.AutoSize = true;
            this.cargo_Candidato.Location = new System.Drawing.Point(84, 21);
            this.cargo_Candidato.Name = "cargo_Candidato";
            this.cargo_Candidato.Size = new System.Drawing.Size(0, 13);
            this.cargo_Candidato.TabIndex = 19;
            // 
            // img_Candidato
            // 
            this.img_Candidato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_Candidato.Location = new System.Drawing.Point(448, 4);
            this.img_Candidato.Name = "img_Candidato";
            this.img_Candidato.Size = new System.Drawing.Size(141, 148);
            this.img_Candidato.TabIndex = 43;
            // 
            // Edita_Candidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 310);
            this.Controls.Add(this.img_Candidato);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.label2sup);
            this.Controls.Add(this.Suplente2);
            this.Controls.Add(this.Suplente1);
            this.Controls.Add(this.bt_incluir);
            this.Controls.Add(this.nome_Vice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_procuraimg);
            this.Controls.Add(this.uf_Lista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_Candidato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nome_Urna);
            this.Controls.Add(this.nome_Candidato);
            this.Controls.Add(this.partidos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cargo_Candidato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label1sup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edita_Candidato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edição Candidato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Label label2sup;
        private System.Windows.Forms.Label label1sup;
        private System.Windows.Forms.TextBox Suplente2;
        private System.Windows.Forms.TextBox Suplente1;
        private System.Windows.Forms.Button bt_incluir;
        private System.Windows.Forms.TextBox nome_Vice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_procuraimg;
        private System.Windows.Forms.ComboBox uf_Lista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox num_Candidato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nome_Urna;
        private System.Windows.Forms.TextBox nome_Candidato;
        private System.Windows.Forms.ComboBox partidos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cargo_Candidato;
        private System.Windows.Forms.Panel img_Candidato;
    }
}