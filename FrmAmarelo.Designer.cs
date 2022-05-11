namespace teste_michele
{
    partial class FrmAmarelo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.exibir = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmamarelo = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmazul = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmvermelho = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibir});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // exibir
            // 
            this.exibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirFrmamarelo,
            this.exibirFrmazul,
            this.exibirFrmvermelho});
            this.exibir.Name = "exibir";
            this.exibir.Size = new System.Drawing.Size(47, 20);
            this.exibir.Text = "Exibir";
            this.exibir.Click += new System.EventHandler(this.exibir_Click);
            // 
            // exibirFrmamarelo
            // 
            this.exibirFrmamarelo.Name = "exibirFrmamarelo";
            this.exibirFrmamarelo.Size = new System.Drawing.Size(180, 22);
            this.exibirFrmamarelo.Text = "FrmAmarelo";
            this.exibirFrmamarelo.Click += new System.EventHandler(this.exibirFrmamarelo_Click);
            // 
            // exibirFrmazul
            // 
            this.exibirFrmazul.Name = "exibirFrmazul";
            this.exibirFrmazul.Size = new System.Drawing.Size(180, 22);
            this.exibirFrmazul.Text = "FrmAzul";
            this.exibirFrmazul.Click += new System.EventHandler(this.exibirFrmazul_Click);
            // 
            // exibirFrmvermelho
            // 
            this.exibirFrmvermelho.Name = "exibirFrmvermelho";
            this.exibirFrmvermelho.Size = new System.Drawing.Size(180, 22);
            this.exibirFrmvermelho.Text = "FrmVermelho";
            this.exibirFrmvermelho.Click += new System.EventHandler(this.exibirFrmvermelho_Click);
            // 
            // FrmAmarelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FrmAmarelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem exibir;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmamarelo;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmazul;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmvermelho;
    }
}

