using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

        }
        

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void txtValor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {

                e.Handled = true;
            }
        }

        private void txtValor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {

                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int resultado = int.Parse(txtValor1.Text) + int.Parse(txtValor2.Text);
            lblResultado.Text = "Resultado: " + resultado.ToString();

        }

       
        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int resultado = int.Parse(txtValor1.Text) - int.Parse(txtValor2.Text);
            lblResultado.Text = "Resultado: " + resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double resultado = double.Parse(txtValor1.Text) / double.Parse(txtValor2.Text);
            lblResultado.Text = "Resultado: " + resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int resultado = int.Parse(txtValor1.Text) * int.Parse(txtValor2.Text);
            lblResultado.Text = "Resultado: " + resultado.ToString();
        }

       
    }
}
