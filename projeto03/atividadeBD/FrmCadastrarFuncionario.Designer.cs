namespace atividadeBD
{
    partial class FrmCadastrarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarFuncionario));
            this.text_nome = new System.Windows.Forms.TextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.text_email = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_setor = new System.Windows.Forms.Label();
            this.comboBox_setor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(185, 64);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(100, 20);
            this.text_nome.TabIndex = 0;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cadastrar.Location = new System.Drawing.Point(124, 183);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(161, 25);
            this.btn_cadastrar.TabIndex = 4;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // text_email
            // 
            this.text_email.Location = new System.Drawing.Point(185, 97);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(209, 20);
            this.text_email.TabIndex = 7;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_nome.Location = new System.Drawing.Point(114, 64);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(70, 25);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_email.Location = new System.Drawing.Point(114, 97);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(66, 25);
            this.lbl_email.TabIndex = 10;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_setor
            // 
            this.lbl_setor.AutoSize = true;
            this.lbl_setor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_setor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_setor.Location = new System.Drawing.Point(114, 128);
            this.lbl_setor.Name = "lbl_setor";
            this.lbl_setor.Size = new System.Drawing.Size(65, 25);
            this.lbl_setor.TabIndex = 11;
            this.lbl_setor.Text = "Setor:";
            // 
            // comboBox_setor
            // 
            this.comboBox_setor.FormattingEnabled = true;
            this.comboBox_setor.Items.AddRange(new object[] {
            "TI",
            "Administração",
            "Logística"});
            this.comboBox_setor.Location = new System.Drawing.Point(185, 132);
            this.comboBox_setor.Name = "comboBox_setor";
            this.comboBox_setor.Size = new System.Drawing.Size(121, 21);
            this.comboBox_setor.TabIndex = 12;
            this.comboBox_setor.Text = "Escolha um Setor";
            // 
            // FrmCadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 294);
            this.Controls.Add(this.comboBox_setor);
            this.Controls.Add(this.lbl_setor);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.text_nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastrarFuncionario";
            this.Text = "FrmCadastrarFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_setor;
        private System.Windows.Forms.ComboBox comboBox_setor;
    }
}