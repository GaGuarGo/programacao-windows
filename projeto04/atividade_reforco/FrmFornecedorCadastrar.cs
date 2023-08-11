using atividade_reforco.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_reforco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = razaoSocial_textBox.Text;
            fornecedor.Email = email_textBox.Text;
            fornecedor.Cnpj = cnpj_textBox.Text;

            Fornecedor.salvarForncedor(fornecedor);

            MessageBox.Show("Fornecedor Cadastrado!");

        }

        private void cnpj_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {

                e.Handled = true;
            }
        }
    }
}
