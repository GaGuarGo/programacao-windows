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
    public partial class FrmListarCliente : Form
    {
        public FrmListarCliente()
        {
            InitializeComponent();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
          Cliente cliente = new Cliente();
          cliente.Id = Int32.Parse(text_id.Text);

            if (Cliente.pesquisar(cliente)) {

                lbl_info.Text = "\n" + cliente.Nome
                 + "\n" + cliente.Email
                 + "\n" + cliente.Idade;

                txt_nome.Text = cliente.Nome;   

                lbl_info.ForeColor = Color.Green;
                btn_excluir.Enabled = true;
                btn_editar.Enabled = true;
                txt_nome.ReadOnly = false;
            }
            else
            {
                lbl_info.Text = "\n" + "Cliente não Encontrado!";
                lbl_info.ForeColor = Color.Red;
            }
            text_id.Focus();

        }

        private void text_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {

                e.Handled = true;
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            string message = "Deseja realmente excluir o registro?";
            string caption = "Exclusão de registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Cliente cli = new Cliente();
                MessageBox.Show(cli.excluir(text_id.Text));
                limpar();
            }
            else
            {
                MessageBox.Show("Cancelado");
            }
            limpar();

        }

        private void limpar()
        {
            text_id.Clear();
            lbl_descricao.Text= "";
            text_id.Focus();
            btn_excluir.Enabled = false;
            btn_editar.Enabled = false;
            txt_nome.ReadOnly = true;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            string message = "Deseja realmente editar o registro?";
            string caption = "Edição de registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Cliente cli = new Cliente();
                cli.Id = Int32.Parse(text_id.Text);
                cli.Nome = txt_nome.Text;


                MessageBox.Show(Cliente.editar(cli));

                limpar();
            }
            else
            {
                MessageBox.Show("Cancelado");
            }
        }
    }
}
