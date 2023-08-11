namespace atividadeBD
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
            this.menuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFuncionarioCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFuncionarioListar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuClienteCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFornecedorCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFornecedorListar = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemProdutoCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemProdutoListar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMenu,
            this.menuCliente,
            this.fornecedorToolStripMenuItem,
            this.produtoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuMenu
            // 
            this.menuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFuncionario,
            this.itemSair});
            this.menuMenu.Name = "menuMenu";
            this.menuMenu.Size = new System.Drawing.Size(50, 20);
            this.menuMenu.Text = "Menu";
            // 
            // itemFuncionario
            // 
            this.itemFuncionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFuncionarioCadastrar,
            this.itemFuncionarioListar});
            this.itemFuncionario.Name = "itemFuncionario";
            this.itemFuncionario.Size = new System.Drawing.Size(137, 22);
            this.itemFuncionario.Text = "Funcionario";
            // 
            // itemFuncionarioCadastrar
            // 
            this.itemFuncionarioCadastrar.Name = "itemFuncionarioCadastrar";
            this.itemFuncionarioCadastrar.Size = new System.Drawing.Size(140, 22);
            this.itemFuncionarioCadastrar.Text = "CADASTRAR";
            this.itemFuncionarioCadastrar.Click += new System.EventHandler(this.itemFuncionarioCadastrar_Click);
            // 
            // itemFuncionarioListar
            // 
            this.itemFuncionarioListar.Name = "itemFuncionarioListar";
            this.itemFuncionarioListar.Size = new System.Drawing.Size(140, 22);
            this.itemFuncionarioListar.Text = "LISTAR";
            this.itemFuncionarioListar.Click += new System.EventHandler(this.itemFuncionarioListar_Click);
            // 
            // itemSair
            // 
            this.itemSair.Name = "itemSair";
            this.itemSair.Size = new System.Drawing.Size(137, 22);
            this.itemSair.Text = "Sair";
            this.itemSair.Click += new System.EventHandler(this.itemSair_Click);
            // 
            // menuCliente
            // 
            this.menuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenuClienteCadastrar,
            this.listarToolStripMenuItem});
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(56, 20);
            this.menuCliente.Text = "Cliente";
            // 
            // itemMenuClienteCadastrar
            // 
            this.itemMenuClienteCadastrar.Name = "itemMenuClienteCadastrar";
            this.itemMenuClienteCadastrar.Size = new System.Drawing.Size(124, 22);
            this.itemMenuClienteCadastrar.Text = "Cadastrar";
            this.itemMenuClienteCadastrar.Click += new System.EventHandler(this.itemMenuClienteCadastrar_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFornecedorCadastrar,
            this.itemFornecedorListar});
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // itemFornecedorCadastrar
            // 
            this.itemFornecedorCadastrar.Name = "itemFornecedorCadastrar";
            this.itemFornecedorCadastrar.Size = new System.Drawing.Size(180, 22);
            this.itemFornecedorCadastrar.Text = "CADASTRAR";
            this.itemFornecedorCadastrar.Click += new System.EventHandler(this.itemFornecedorCadastrar_Click);
            // 
            // itemFornecedorListar
            // 
            this.itemFornecedorListar.Name = "itemFornecedorListar";
            this.itemFornecedorListar.Size = new System.Drawing.Size(180, 22);
            this.itemFornecedorListar.Text = "LISTAR";
            this.itemFornecedorListar.Click += new System.EventHandler(this.itemFornecedorListar_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemProdutoCadastrar,
            this.itemProdutoListar});
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // itemProdutoCadastrar
            // 
            this.itemProdutoCadastrar.Name = "itemProdutoCadastrar";
            this.itemProdutoCadastrar.Size = new System.Drawing.Size(180, 22);
            this.itemProdutoCadastrar.Text = "CADASTRAR";
            this.itemProdutoCadastrar.Click += new System.EventHandler(this.itemProdutoCadastrar_Click);
            // 
            // itemProdutoListar
            // 
            this.itemProdutoListar.Name = "itemProdutoListar";
            this.itemProdutoListar.Size = new System.Drawing.Size(180, 22);
            this.itemProdutoListar.Text = "LISTAR";
            this.itemProdutoListar.Click += new System.EventHandler(this.itemProdutoListar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "EmpresaAPP";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuMenu;
        private System.Windows.Forms.ToolStripMenuItem itemFuncionario;
        private System.Windows.Forms.ToolStripMenuItem itemFuncionarioCadastrar;
        private System.Windows.Forms.ToolStripMenuItem itemFuncionarioListar;
        private System.Windows.Forms.ToolStripMenuItem itemSair;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem itemMenuClienteCadastrar;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemFornecedorCadastrar;
        private System.Windows.Forms.ToolStripMenuItem itemFornecedorListar;
        private System.Windows.Forms.ToolStripMenuItem itemProdutoCadastrar;
        private System.Windows.Forms.ToolStripMenuItem itemProdutoListar;
    }
}

