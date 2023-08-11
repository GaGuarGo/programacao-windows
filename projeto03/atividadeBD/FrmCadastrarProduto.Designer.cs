namespace atividadeBD
{
    partial class FrmCadastrarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarProduto));
            this.lbl_estoque = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.text_estoque = new System.Windows.Forms.TextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_estoque
            // 
            this.lbl_estoque.AutoSize = true;
            this.lbl_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estoque.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_estoque.Location = new System.Drawing.Point(119, 163);
            this.lbl_estoque.Name = "lbl_estoque";
            this.lbl_estoque.Size = new System.Drawing.Size(90, 25);
            this.lbl_estoque.TabIndex = 17;
            this.lbl_estoque.Text = "Estoque:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_nome.Location = new System.Drawing.Point(139, 108);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(70, 25);
            this.lbl_nome.TabIndex = 16;
            this.lbl_nome.Text = "Nome:";
            // 
            // text_estoque
            // 
            this.text_estoque.Location = new System.Drawing.Point(210, 169);
            this.text_estoque.Name = "text_estoque";
            this.text_estoque.Size = new System.Drawing.Size(100, 20);
            this.text_estoque.TabIndex = 15;
            this.text_estoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_estoque_KeyPress);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cadastrar.Location = new System.Drawing.Point(149, 227);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(161, 37);
            this.btn_cadastrar.TabIndex = 14;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(210, 108);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(100, 20);
            this.text_nome.TabIndex = 13;
            // 
            // FrmCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 366);
            this.Controls.Add(this.lbl_estoque);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.text_estoque);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.text_nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastrarProduto";
            this.Text = "FrmCadastrarProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_estoque;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox text_estoque;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.TextBox text_nome;
    }
}