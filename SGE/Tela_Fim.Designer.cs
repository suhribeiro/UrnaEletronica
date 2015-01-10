namespace SGE
{
    partial class Tela_Fim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Fim));
            this.camp_fim = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.camp_votou = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // camp_fim
            // 
            this.camp_fim.AutoSize = true;
            this.camp_fim.BackColor = System.Drawing.Color.Transparent;
            this.camp_fim.Font = new System.Drawing.Font("Arial", 110F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camp_fim.Location = new System.Drawing.Point(74, 83);
            this.camp_fim.Name = "camp_fim";
            this.camp_fim.Size = new System.Drawing.Size(323, 165);
            this.camp_fim.TabIndex = 0;
            this.camp_fim.Text = "FIM";
            this.camp_fim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.camp_votou);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 305);
            this.panel1.TabIndex = 1;
            // 
            // camp_votou
            // 
            this.camp_votou.AutoSize = true;
            this.camp_votou.BackColor = System.Drawing.Color.Transparent;
            this.camp_votou.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camp_votou.Location = new System.Drawing.Point(336, 273);
            this.camp_votou.Name = "camp_votou";
            this.camp_votou.Size = new System.Drawing.Size(109, 32);
            this.camp_votou.TabIndex = 0;
            this.camp_votou.Text = "VOTOU";
            this.camp_votou.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tela_Fim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(470, 330);
            this.Controls.Add(this.camp_fim);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_Fim";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label camp_fim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label camp_votou;






    }
}