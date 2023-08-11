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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
        }




        private void itemSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você está Saindo do Sistema!");
            Application.Exit();
        }

        private void itemFuncionarioCadastrar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCadastrarFuncionario>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmCadastrarFuncionario>().First().Focus();
            }
            else
            {
                FrmCadastrarFuncionario frm = new FrmCadastrarFuncionario();
                frm.Show();
            }

        }

        private void itemFuncionarioListar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmListarFuncionario>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmListarFuncionario>().First().Focus();
            }
            else
            {
                FrmListarFuncionario frm = new FrmListarFuncionario();
                frm.Show();
            }
        }

        private void itemMenuClienteCadastrar_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<FrmCadastrarCliente>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmCadastrarCliente>().First().Focus();
            }
            else
            {
                FrmCadastrarCliente frm = new FrmCadastrarCliente();
                frm.Show();
            }

        }

        public void listarToolStripMenuItem_Click()
        {
            if (Application.OpenForms.OfType<FrmListarCliente>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmListarCliente>().First().Focus();
            }
            else
            {
                FrmListarCliente frm = new FrmListarCliente();
                frm.Show();
            }
        }

        private void itemFornecedorCadastrar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormCadastrarFornecedor>().Count() > 0)
            {
                Application.OpenForms.OfType<FormCadastrarFornecedor>().First().Focus();
            }
            else
            {
                FormCadastrarFornecedor frm = new FormCadastrarFornecedor();
                frm.Show();
            }
        }

        private void itemFornecedorListar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmListarFornecedor>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmListarFornecedor>().First().Focus();
            }
            else
            {
                FrmListarFornecedor frm = new FrmListarFornecedor();
                frm.Show();
            }
        }

        private void itemProdutoCadastrar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCadastrarProduto>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmCadastrarProduto>().First().Focus();
            }
            else
            {
                FrmCadastrarProduto frm = new FrmCadastrarProduto();
                frm.Show();
            }
        }

        private void itemProdutoListar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmListarProduto>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmListarProduto>().First().Focus();
            }
            else
            {
                FrmListarProduto frm = new FrmListarProduto();
                frm.Show();
            }
        }
    }
}
