using atividadeBD.Class;
using K4os.Compression.LZ4.Encoders;
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
    public partial class FrmCadastrarProduto : Form
    {
        public FrmCadastrarProduto()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

            Produto p = new Produto();
            p.Nome = text_nome.Text;
            p.Estoque = text_estoque.Text.ToString();

            MessageBox.Show(Produto.cadastrarProduto(p));

            clear();
        }

        private void text_estoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {

                e.Handled = true;
            }
        }

        public void clear()
        {

            text_nome.Clear();
            text_estoque.Clear();

        }
    }
}
