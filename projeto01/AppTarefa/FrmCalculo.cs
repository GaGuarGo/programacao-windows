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
    public partial class FrmCalculo : Form
    {
        public FrmCalculo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCalculo_Load(object sender, EventArgs e)
        {

        }

       

        private void textValor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textValor2_TextChanged(object sender, EventArgs e)
        {

        }
        
        
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {

            int resultado = int.Parse(textValor1.Text) + int.Parse(textValor2.Text);
            lblResultado.Text = "Resultado: " + resultado.ToString();

        }
        private void textValor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 ) {
            
                e.Handled = true;
            } 
        }

        private void textValor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {

                e.Handled = true;
            }
        }
    }
}
