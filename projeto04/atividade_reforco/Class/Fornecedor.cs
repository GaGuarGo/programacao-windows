﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_reforco.Class
{
    internal class Fornecedor
    {

        private int id;
        private string razaoSocial;
        private string email;
        private string cnpj;

        public int Id { get => id; set => id = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string Email { get => email; set => email = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }


        public static void salvarForncedor(Fornecedor f)
        {

            try
            {

                MySqlConnection conn = Conexao.obterConexao();
                string sql = "INSERT INTO fornecedor VALUES (null, @razaoSocial, @email, @cnpj)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@razaoSocial", f.razaoSocial);
                cmd.Parameters.AddWithValue("@email", f.email);
                cmd.Parameters.AddWithValue("@cnpj", f.cnpj);
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException e)
            {

                MessageBox.Show(e.ToString());

            }


        }


    }
}
