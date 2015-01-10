namespace SGE
{
    partial class Cadastro_Eleitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Eleitor));
            this.label_Nome = new System.Windows.Forms.Label();
            this.label_Inscrição = new System.Windows.Forms.Label();
            this.label_UF = new System.Windows.Forms.Label();
            this.label_Zona = new System.Windows.Forms.Label();
            this.label_Secao = new System.Windows.Forms.Label();
            this.nome_Eleitor = new System.Windows.Forms.TextBox();
            this.zona_Eleitor = new System.Windows.Forms.TextBox();
            this.inscricao_Eleitor = new System.Windows.Forms.TextBox();
            this.secao_Eleitor = new System.Windows.Forms.TextBox();
            this.bt_incluir = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.uf_Eleitor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Location = new System.Drawing.Point(34, 40);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(35, 13);
            this.label_Nome.TabIndex = 0;
            this.label_Nome.Text = "Nome";
            // 
            // label_Inscrição
            // 
            this.label_Inscrição.AutoSize = true;
            this.label_Inscrição.Location = new System.Drawing.Point(19, 89);
            this.label_Inscrição.Name = "label_Inscrição";
            this.label_Inscrição.Size = new System.Drawing.Size(50, 13);
            this.label_Inscrição.TabIndex = 1;
            this.label_Inscrição.Text = "Inscrição";
            // 
            // label_UF
            // 
            this.label_UF.AutoSize = true;
            this.label_UF.Location = new System.Drawing.Point(429, 40);
            this.label_UF.Name = "label_UF";
            this.label_UF.Size = new System.Drawing.Size(21, 13);
            this.label_UF.TabIndex = 2;
            this.label_UF.Text = "UF";
            // 
            // label_Zona
            // 
            this.label_Zona.AutoSize = true;
            this.label_Zona.Location = new System.Drawing.Point(37, 143);
            this.label_Zona.Name = "label_Zona";
            this.label_Zona.Size = new System.Drawing.Size(32, 13);
            this.label_Zona.TabIndex = 4;
            this.label_Zona.Text = "Zona";
            // 
            // label_Secao
            // 
            this.label_Secao.AutoSize = true;
            this.label_Secao.Location = new System.Drawing.Point(259, 143);
            this.label_Secao.Name = "label_Secao";
            this.label_Secao.Size = new System.Drawing.Size(38, 13);
            this.label_Secao.TabIndex = 5;
            this.label_Secao.Text = "Seção";
            // 
            // nome_Eleitor
            // 
            this.nome_Eleitor.Location = new System.Drawing.Point(75, 37);
            this.nome_Eleitor.Name = "nome_Eleitor";
            this.nome_Eleitor.Size = new System.Drawing.Size(295, 20);
            this.nome_Eleitor.TabIndex = 0;
            this.nome_Eleitor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteLetras_KeyPress);
            // 
            // zona_Eleitor
            // 
            this.zona_Eleitor.Location = new System.Drawing.Point(75, 140);
            this.zona_Eleitor.MaxLength = 4;
            this.zona_Eleitor.Name = "zona_Eleitor";
            this.zona_Eleitor.Size = new System.Drawing.Size(67, 20);
            this.zona_Eleitor.TabIndex = 3;
            this.zona_Eleitor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zona_Eleitor_KeyPress);
            // 
            // inscricao_Eleitor
            // 
            this.inscricao_Eleitor.Location = new System.Drawing.Point(75, 86);
            this.inscricao_Eleitor.MaxLength = 12;
            this.inscricao_Eleitor.Name = "inscricao_Eleitor";
            this.inscricao_Eleitor.Size = new System.Drawing.Size(295, 20);
            this.inscricao_Eleitor.TabIndex = 2;
            this.inscricao_Eleitor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inscricao_Eleitor_KeyPress);
            // 
            // secao_Eleitor
            // 
            this.secao_Eleitor.Location = new System.Drawing.Point(303, 140);
            this.secao_Eleitor.MaxLength = 4;
            this.secao_Eleitor.Name = "secao_Eleitor";
            this.secao_Eleitor.Size = new System.Drawing.Size(67, 20);
            this.secao_Eleitor.TabIndex = 4;
            this.secao_Eleitor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secao_Eleitor_KeyPress);
            // 
            // bt_incluir
            // 
            this.bt_incluir.Location = new System.Drawing.Point(180, 278);
            this.bt_incluir.Name = "bt_incluir";
            this.bt_incluir.Size = new System.Drawing.Size(75, 20);
            this.bt_incluir.TabIndex = 5;
            this.bt_incluir.Text = "Incluir";
            this.bt_incluir.UseVisualStyleBackColor = true;
            this.bt_incluir.Click += new System.EventHandler(this.bt_incluir_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(261, 278);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(75, 20);
            this.bt_limpar.TabIndex = 6;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(342, 278);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 20);
            this.bt_cancelar.TabIndex = 7;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // uf_Eleitor
            // 
            this.uf_Eleitor.FormattingEnabled = true;
            this.uf_Eleitor.Location = new System.Drawing.Point(456, 37);
            this.uf_Eleitor.Name = "uf_Eleitor";
            this.uf_Eleitor.Size = new System.Drawing.Size(55, 21);
            this.uf_Eleitor.TabIndex = 1;
            this.uf_Eleitor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uf_Eleitor_KeyDown);
            this.uf_Eleitor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uf_Eleitor_KeyPress);
            // 
            // Cadastro_Eleitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 310);
            this.Controls.Add(this.uf_Eleitor);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_incluir);
            this.Controls.Add(this.secao_Eleitor);
            this.Controls.Add(this.inscricao_Eleitor);
            this.Controls.Add(this.zona_Eleitor);
            this.Controls.Add(this.nome_Eleitor);
            this.Controls.Add(this.label_Secao);
            this.Controls.Add(this.label_Zona);
            this.Controls.Add(this.label_UF);
            this.Controls.Add(this.label_Inscrição);
            this.Controls.Add(this.label_Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro_Eleitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Eleitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.Label label_Inscrição;
        private System.Windows.Forms.Label label_UF;
        private System.Windows.Forms.Label label_Zona;
        private System.Windows.Forms.Label label_Secao;
        private System.Windows.Forms.TextBox nome_Eleitor;
        private System.Windows.Forms.TextBox zona_Eleitor;
        private System.Windows.Forms.TextBox inscricao_Eleitor;
        private System.Windows.Forms.TextBox secao_Eleitor;
        private System.Windows.Forms.Button bt_incluir;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.ComboBox uf_Eleitor;
    }
}