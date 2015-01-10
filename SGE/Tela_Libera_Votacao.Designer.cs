namespace SGE
{
    partial class Tela_Libera_Votacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Libera_Votacao));
            this.insere_Inscricao = new System.Windows.Forms.TextBox();
            this.bt_Liberar = new System.Windows.Forms.Button();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.inscricao_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // insere_Inscricao
            // 
            this.insere_Inscricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insere_Inscricao.Location = new System.Drawing.Point(146, 119);
            this.insere_Inscricao.MaxLength = 12;
            this.insere_Inscricao.Name = "insere_Inscricao";
            this.insere_Inscricao.Size = new System.Drawing.Size(474, 80);
            this.insere_Inscricao.TabIndex = 0;
            this.insere_Inscricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.insere_Inscricao_KeyPress);
            // 
            // bt_Liberar
            // 
            this.bt_Liberar.Location = new System.Drawing.Point(277, 285);
            this.bt_Liberar.Name = "bt_Liberar";
            this.bt_Liberar.Size = new System.Drawing.Size(75, 20);
            this.bt_Liberar.TabIndex = 1;
            this.bt_Liberar.Text = "Liberar";
            this.bt_Liberar.UseVisualStyleBackColor = true;
            this.bt_Liberar.Click += new System.EventHandler(this.bt_Liberar_Click);
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Location = new System.Drawing.Point(358, 285);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(75, 20);
            this.bt_Limpar.TabIndex = 2;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(439, 285);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 20);
            this.bt_cancelar.TabIndex = 3;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // inscricao_Label
            // 
            this.inscricao_Label.AutoSize = true;
            this.inscricao_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscricao_Label.Location = new System.Drawing.Point(260, 57);
            this.inscricao_Label.Name = "inscricao_Label";
            this.inscricao_Label.Size = new System.Drawing.Size(264, 31);
            this.inscricao_Label.TabIndex = 4;
            this.inscricao_Label.Text = "Número de Inscrição";
            // 
            // Tela_Libera_Votacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 317);
            this.Controls.Add(this.inscricao_Label);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.bt_Liberar);
            this.Controls.Add(this.insere_Inscricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tela_Libera_Votacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberar Votação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox insere_Inscricao;
        private System.Windows.Forms.Button bt_Liberar;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Label inscricao_Label;
    }
}