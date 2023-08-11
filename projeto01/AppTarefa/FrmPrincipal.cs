using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTarefa
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void itemOperacoesVender_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmVender>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmVender>().First().Focus();
            }
            else
            {
                FrmVender frm = new FrmVender();
                frm.Show();
            }
        }

        private void itemOperacoesRepor_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmReporEstoque>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmReporEstoque>().First().Focus();
            }
            else
            {
                FrmReporEstoque frm = new FrmReporEstoque();
                frm.Show();
            }
        }

        private void itemOperacoesSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você está Saindo do Aplicativo!");
            Application.Exit();

        }

        private void exemplosMenu_Click(object sender, EventArgs e)
        {

        }

        private void itemExemplosCalculo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCalculo>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmCalculo>().First().Focus();
            }
            else
            {
                FrmCalculo frm = new FrmCalculo();
                frm.Show();
            }
        }
    }
}
