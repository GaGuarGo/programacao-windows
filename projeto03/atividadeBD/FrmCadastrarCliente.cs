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
    public partial class FrmCadastrarCliente : Form
    {
        public FrmCadastrarCliente()
        {
            InitializeComponent();
        }

        private void txt_idade_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {

                e.Handled = true;
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {


            Cliente cliente = new Cliente();
            cliente.Nome = text_nome.Text;
            cliente.Email = text_email.Text;
            cliente.Idade = int.Parse(txt_idade.Text);

            MessageBox.Show(Cliente.salvar(cliente));



        }
    }
}
