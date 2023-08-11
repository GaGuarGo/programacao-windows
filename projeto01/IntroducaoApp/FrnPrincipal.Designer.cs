namespace IntroducaoApp
{
    partial class FrnPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrnPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.abaOpcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOpcoesCalculo = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOpcoesSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abaOpcoes});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1385, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            this.menuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // abaOpcoes
            // 
            this.abaOpcoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemOpcoesCalculo,
            this.itemOpcoesSair});
            this.abaOpcoes.Name = "abaOpcoes";
            this.abaOpcoes.Size = new System.Drawing.Size(59, 20);
            this.abaOpcoes.Text = "Opções";
            this.abaOpcoes.Click += new System.EventHandler(this.abaOpcoes_Click);
            // 
            // itemOpcoesCalculo
            // 
            this.itemOpcoesCalculo.Name = "itemOpcoesCalculo";
            this.itemOpcoesCalculo.Size = new System.Drawing.Size(180, 22);
            this.itemOpcoesCalculo.Text = "Cálculo";
            this.itemOpcoesCalculo.Click += new System.EventHandler(this.itemOpcoesCalculo_Click);
            // 
            // itemOpcoesSair
            // 
            this.itemOpcoesSair.Name = "itemOpcoesSair";
            this.itemOpcoesSair.Size = new System.Drawing.Size(180, 22);
            this.itemOpcoesSair.Text = "Sair";
            this.itemOpcoesSair.Click += new System.EventHandler(this.itemOpcoesSair_Click);
            // 
            // FrnPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1385, 552);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrnPrincipal";
            this.Text = "App de Introdução";
            this.Load += new System.EventHandler(this.FrnPrincipal_Load);
            this.Click += new System.EventHandler(this.itemOpcoesSair_Click);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem abaOpcoes;
        private System.Windows.Forms.ToolStripMenuItem itemOpcoesCalculo;
        private System.Windows.Forms.ToolStripMenuItem itemOpcoesSair;
    }
}

