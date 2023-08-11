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
    public partial class FrmListarProduto : Form
    {
        public FrmListarProduto()
        {
            InitializeComponent();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            lbl_info.Text = Produto.listarProduto(id: text_id.Text.ToString());
        }

        private void text_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {

                e.Handled = true;
            }
        }
    }
}
