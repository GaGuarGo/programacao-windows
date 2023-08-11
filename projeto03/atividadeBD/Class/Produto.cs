using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeBD.Class
{
    internal class Produto
    {

        private int id;
        private string nome;
        private string estoque;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Estoque { get => estoque; set => estoque = value; }


        public static string cadastrarProduto(Produto p) {

            try {

                MySqlConnection conn = Conexao.obterConexao();
                string sql = "INSERT INTO produtos VALUES(null, @nome, @estoque)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", p.Nome);
                cmd.Parameters.AddWithValue("@estoque", p.Estoque);
                cmd.ExecuteNonQuery();

                return "Produto Salvo!";
                

            }
            catch (MySqlException e){
            
                return "Erro: " + e.Message;
            
            }
        

        
        }


        public static string listarProduto(String id)
        {

            MySqlConnection conn = Conexao.obterConexao();
            string sql = "SELECT * FROM produtos WHERE id = " + id;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader res = cmd.ExecuteReader();

            string lista = "Lista de Categorias: \n";
            if(res.HasRows)
            {

                while(res.Read())
                {

                    lista += "ID:" + res["id"].ToString() + "\n";

                    lista += "Nome:" + res["nome"].ToString() + "\n";

                    lista += "Quantidade Estoque:" + res["estoque"].ToString() + "\n";

                }

            } else
            {

                lista = "ID não cadastrado!";
            }


            return lista;
        }

    }
}
