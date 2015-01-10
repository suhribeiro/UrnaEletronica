namespace SGE
{
    partial class Tela_FInaliza_Votacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_FInaliza_Votacao));
            this.finaliza = new System.Windows.Forms.Button();
            this.senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // finaliza
            // 
            this.finaliza.Location = new System.Drawing.Point(85, 141);
            this.finaliza.Name = "finaliza";
            this.finaliza.Size = new System.Drawing.Size(109, 23);
            this.finaliza.TabIndex = 0;
            this.finaliza.Text = "Finalizar votação";
            this.finaliza.UseVisualStyleBackColor = true;
            this.finaliza.Click += new System.EventHandler(this.finaliza_Click);
            // 
            // senha
            // 
            this.senha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.senha.Location = new System.Drawing.Point(36, 88);
            this.senha.Name = "senha";
            this.senha.PasswordChar = '●';
            this.senha.Size = new System.Drawing.Size(211, 20);
            this.senha.TabIndex = 1;
            this.senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira a senha do presidente da seção:";
            // 
            // Tela_FInaliza_Votacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.finaliza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tela_FInaliza_Votacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FInaliza Votação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button finaliza;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Label label1;
    }
}