namespace AppTarefa
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operacoesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOperacoesVender = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOperacoesRepor = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOperacoesSair = new System.Windows.Forms.ToolStripMenuItem();
            this.exemplosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExemplosCalculo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacoesMenu,
            this.exemplosMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operacoesMenu
            // 
            this.operacoesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemOperacoesVender,
            this.itemOperacoesRepor,
            this.itemOperacoesSair});
            this.operacoesMenu.Name = "operacoesMenu";
            this.operacoesMenu.Size = new System.Drawing.Size(75, 20);
            this.operacoesMenu.Text = "Operações";
            // 
            // itemOperacoesVender
            // 
            this.itemOperacoesVender.Name = "itemOperacoesVender";
            this.itemOperacoesVender.Size = new System.Drawing.Size(180, 22);
            this.itemOperacoesVender.Text = "Vender";
            this.itemOperacoesVender.Click += new System.EventHandler(this.itemOperacoesVender_Click);
            // 
            // itemOperacoesRepor
            // 
            this.itemOperacoesRepor.Name = "itemOperacoesRepor";
            this.itemOperacoesRepor.Size = new System.Drawing.Size(180, 22);
            this.itemOperacoesRepor.Text = "Repor Estoque";
            this.itemOperacoesRepor.Click += new System.EventHandler(this.itemOperacoesRepor_Click);
            // 
            // itemOperacoesSair
            // 
            this.itemOperacoesSair.Name = "itemOperacoesSair";
            this.itemOperacoesSair.Size = new System.Drawing.Size(180, 22);
            this.itemOperacoesSair.Text = "Sair";
            this.itemOperacoesSair.Click += new System.EventHandler(this.itemOperacoesSair_Click);
            // 
            // exemplosMenu
            // 
            this.exemplosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemExemplosCalculo});
            this.exemplosMenu.Name = "exemplosMenu";
            this.exemplosMenu.Size = new System.Drawing.Size(70, 20);
            this.exemplosMenu.Text = "Exemplos";
            this.exemplosMenu.Click += new System.EventHandler(this.exemplosMenu_Click);
            // 
            // itemExemplosCalculo
            // 
            this.itemExemplosCalculo.Name = "itemExemplosCalculo";
            this.itemExemplosCalculo.Size = new System.Drawing.Size(180, 22);
            this.itemExemplosCalculo.Text = "Cálculo";
            this.itemExemplosCalculo.Click += new System.EventHandler(this.itemExemplosCalculo_Click);
            // 
            // FrmPrincipal
            // 
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1041, 636);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "App TAREFA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operacoesMenu;
        private System.Windows.Forms.ToolStripMenuItem itemOperacoesVender;
        private System.Windows.Forms.ToolStripMenuItem itemOperacoesRepor;
        private System.Windows.Forms.ToolStripMenuItem itemOperacoesSair;
        private System.Windows.Forms.ToolStripMenuItem exemplosMenu;
        private System.Windows.Forms.ToolStripMenuItem itemExemplosCalculo;
    }
}

