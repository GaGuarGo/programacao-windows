﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividadeBD.Class
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


        public static string salvarForncedor(Fornecedor f)
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


                return "Salvo com Sucesso!";

            }
            catch (MySqlException e)
            {

                return "Erro" + e.Message;

            }


        }


        public static string listarFornedor(String id)
        {

            MySqlConnection conn = Conexao.obterConexao();
            string sql = "SELECT * FROM fornecedor WHERE id = " + id;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader res = cmd.ExecuteReader();

            string lista = "Lista de categorias: \n";
            if (res.HasRows)
            {
                while (res.Read())
                {
                    lista += "ID: " + res["id"].ToString() + "\n";
                    lista += "Nome: " + res["razaoSocial"].ToString() + "\n";
                    lista += "Email: " + res["email"].ToString() + "\n";
                    lista += "CNPJ: " + res["cnpj"].ToString() + "\n";
                    lista += "\n";
                }

            } else
            {

                lista = "Fornecedor não Cadastrado!";

            }
            return lista;


        }

    }
}
