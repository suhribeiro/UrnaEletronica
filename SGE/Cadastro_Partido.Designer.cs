namespace SGE
{
    partial class Cadastro_Partido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Partido));
            this.label1 = new System.Windows.Forms.Label();
            this.nome_Partido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sigla_Partido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.num_Partido = new System.Windows.Forms.TextBox();
            this.bt_Incluir = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // nome_Partido
            // 
            this.nome_Partido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nome_Partido.Location = new System.Drawing.Point(54, 48);
            this.nome_Partido.Name = "nome_Partido";
            this.nome_Partido.Size = new System.Drawing.Size(338, 20);
            this.nome_Partido.TabIndex = 0;
            this.nome_Partido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteLetras_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sigla";
            // 
            // sigla_Partido
            // 
            this.sigla_Partido.Location = new System.Drawing.Point(54, 104);
            this.sigla_Partido.Name = "sigla_Partido";
            this.sigla_Partido.Size = new System.Drawing.Size(72, 20);
            this.sigla_Partido.TabIndex = 1;
            this.sigla_Partido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteLetras_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Número";
            // 
            // num_Partido
            // 
            this.num_Partido.Location = new System.Drawing.Point(54, 159);
            this.num_Partido.MaxLength = 2;
            this.num_Partido.Name = "num_Partido";
            this.num_Partido.Size = new System.Drawing.Size(31, 20);
            this.num_Partido.TabIndex = 2;
            this.num_Partido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_Partido_KeyPress);
            // 
            // bt_Incluir
            // 
            this.bt_Incluir.Location = new System.Drawing.Point(180, 278);
            this.bt_Incluir.Name = "bt_Incluir";
            this.bt_Incluir.Size = new System.Drawing.Size(75, 20);
            this.bt_Incluir.TabIndex = 3;
            this.bt_Incluir.Text = "Incluir";
            this.bt_Incluir.UseVisualStyleBackColor = true;
            this.bt_Incluir.Click += new System.EventHandler(this.bt_Incluir_Click);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.Location = new System.Drawing.Point(342, 278);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(75, 20);
            this.bt_Cancelar.TabIndex = 4;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            this.bt_Cancelar.Click += new System.EventHandler(this.bt_Cancelar_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(261, 278);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(75, 20);
            this.bt_limpar.TabIndex = 5;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // Cadastro_Partido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 310);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_Incluir);
            this.Controls.Add(this.num_Partido);
            this.Controls.Add(this.sigla_Partido);
            this.Controls.Add(this.nome_Partido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro_Partido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Partido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nome_Partido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sigla_Partido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox num_Partido;
        private System.Windows.Forms.Button bt_Incluir;
        private System.Windows.Forms.Button bt_Cancelar;
        private System.Windows.Forms.Button bt_limpar;
    }
}