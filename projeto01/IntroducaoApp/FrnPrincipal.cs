using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroducaoApp
{
    public partial class FrnPrincipal : Form
    {
        public FrnPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FrnPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void itemOpcoesCalculo_Click(object sender, EventArgs e)
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

        private void itemOpcoesSair_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Você está Saindo!");
            Application.Exit();

        }

        private void abaOpcoes_Click(object sender, EventArgs e)
        {

        }
    }
}
