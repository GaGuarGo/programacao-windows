using atividadeBD.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividadeBD
{
    public partial class FormCadastrarFornecedor : Form
    {
        public FormCadastrarFornecedor()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.RazaoSocial = razaoSocial_textBox.Text;
            fornecedor.Email = email_textBox.Text;
            fornecedor.Cnpj = cnpj_textBox.Text;



            MessageBox.Show(Fornecedor.salvarForncedor(fornecedor));
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
