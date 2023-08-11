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
    public partial class FrmCadastrarFuncionario : Form
    {
        public FrmCadastrarFuncionario()
        {
            InitializeComponent();
        }



        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

            Categoria categoria = new Categoria();
            categoria.Nome = text_nome.Text;
            categoria.Email= text_email.Text;
            categoria.Setor = comboBox_setor.Text;

           

            MessageBox.Show(Categoria.salvar(categoria));

            clear();
            
        }

        private void clear()
        {

            text_nome.Clear();
            comboBox_setor.Items.Clear();
            text_email.Clear();

            text_nome.Focus();

        }

    }
}
