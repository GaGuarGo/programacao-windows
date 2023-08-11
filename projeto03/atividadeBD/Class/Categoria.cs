using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
//add
using MySql.Data.MySqlClient;

namespace atividadeBD.Class
{
    internal class Categoria
    {

        private int id;
        private string nome;
        private string email;
        private string setor;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Setor { get => setor; set => setor = value; }


        public  static string  salvar( Categoria c ) { 
        
            try
            {

                MySqlConnection conn = Conexao.obterConexao();
                string sql = "INSERT INTO funcionario VALUES (null, @nome, @email, @setor)"; 
                MySqlCommand cmd = new MySqlCommand( sql, conn );
                cmd.Parameters.AddWithValue("@nome", c.nome) ;
                cmd.Parameters.AddWithValue("@email", c.email);
                cmd.Parameters.AddWithValue("@setor", c.setor);
                cmd.ExecuteNonQuery();

                return "Salvo com Sucesso!";

            } catch (MySqlException e) {

                return "Erro: " + e.Message;
            
            }
        
        }


        public static string listar( String id )
        {

            MySqlConnection conn = Conexao.obterConexao();
            string sql = "SELECT * FROM funcionario WHERE id = " + id;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader res = cmd.ExecuteReader();

            string lista = "Lista de categorias: \n";
            if (res.HasRows)
            {
                while (res.Read())
                {
                    lista += "ID: " + res["id"].ToString() + "\n";
                    lista += "Nome: " + res["nome"].ToString() + "\n";
                    lista += "Email: " + res["email"].ToString() + "\n";
                    lista += "Setor: " + res["setor"].ToString() + "\n";
                    lista += "\n";
                }
                
            } else
            {

                lista = "Funcionário não Econtrado!";

            }
            return lista;
        }


        public static Boolean pesquisar(Categoria c)
        {

            MySqlConnection conn = Conexao.obterConexao();
            string sql = "SELECT * FROM funcionario WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", c.id);
            MySqlDataReader res = cmd.ExecuteReader();

            Boolean verificar = false;

          
            if (res.HasRows)
            {
                if (res.Read())
                {
                    c.Id = Int32.Parse(res["id"].ToString());
                    c.Nome = res["nome"].ToString();    
                    c.Email = res["email"].ToString();
                    c.Setor = res["setor"].ToString();

                    verificar = true;
                }


            }
            else
            {
                verificar = false;

            }
            return verificar;
        }

        public string excluir(string id)
        {
            try
            {
                MySqlConnection conn = Conexao.obterConexao();
                string sql = "DELETE FROM funcionario WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return "excluído";
            }
            catch (Exception e)
            {
                return "erro: " + e.Message;
            }
        }

        public static string editar(Categoria c)
        {

            try
            {

                MySqlConnection conn = Conexao.obterConexao();
                string sql = "UPDATE funcionario SET nome = @nome WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", c.id);
                cmd.Parameters.AddWithValue("@nome", c.nome);
                cmd.ExecuteNonQuery();

                return "Editado com Sucesso!";

            }
            catch (MySqlException e)
            {

                return "Erro: " + e.Message;

            }

        }

    }
}
