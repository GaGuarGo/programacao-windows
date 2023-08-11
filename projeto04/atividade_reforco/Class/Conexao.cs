using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_reforco.Class
{
    internal class Conexao
    {

        private static MySqlConnection conn = null;
        public static MySqlConnection obterConexao()
        {

            conn = new MySqlConnection("Server=localhost;Database=bdreforco;Uid=root;Pwd=;");

            try
            {

                conn.Open();
                MessageBox.Show("Conexão Estabelecida!");

            }
            catch (MySqlException e)
            {

                conn = null;
                MessageBox.Show(e.Message);


            }

            return conn;

        }


        public static void fecharConexao()
        {

            if (conn != null)
            {
                conn.Close();
            }

        }

    }
}
