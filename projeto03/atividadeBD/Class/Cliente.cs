using MySql.Data.MySqlClient;
using Mysqlx.Expr;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividadeBD.Class
{
    internal class Cliente
    {

        private int id;
        private string nome;
        private string email;
        private int idade;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public int Idade { get => idade; set => idade = value; }


        public static string salvar(Cliente c)
        {

            try
            {

                MySqlConnection conn = Conexao.obterConexao();
                string sql = "INSERT INTO cliente VALUES (null, @nome, @email, @idade)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", c.nome);
                cmd.Parameters.AddWithValue("@email", c.email);
                cmd.Parameters.AddWithValue("@idade", c.idade);
                cmd.ExecuteNonQuery();


                return "Salvo com Sucesso!";
            }
            catch (MySqlException e)
            {

               
                return "Erro: " + e.Message;
            }

        }

        public static string salvarEditar(Cliente cli, FrmPrincipal frmPrincipal) {


            try
            {

                MySqlConnection conn = Conexao.obterConexao();
                string sql = "INSERT INTO cliente VALUES (null, @nome, @email, @idade)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", cli.nome);
                cmd.Parameters.AddWithValue("@email", cli.email);
                cmd.Parameters.AddWithValue("@idade", cli.idade);
                cmd.ExecuteNonQuery();

                string message = "Deseja realmente editar o registro?";
                string caption = "Edição de registro";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                 frmPrincipal.listarToolStripMenuItem_Click();
                }
                else
                {
                    return "Edição Cancelada";
                }

                

                return "Sucesso ao Cadastrar!";
                
            }
            catch (MySqlException e)
            {

                return "Erro" + e.Message;
                
            }

        }

        public static string listar(String id)
        {

            MySqlConnection conn = Conexao.obterConexao();
            string sql = "SELECT * FROM cliente WHERE id = " + id;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader res = cmd.ExecuteReader();

            string lista = "Lista de categorias: \n";
            if (res.HasRows)
            {
                while (res.Read())
                {
                    lista += "Nome: " + res["nome"].ToString() + "\n";
                    lista += "Email: " + res["email"].ToString() + "\n";
                    lista += "Idade: " + res["idade"].ToString() + "\n";
                    lista += "\n";
                }

            } else
            {

                lista = "Cliente não Encontrado";

            }
            return lista;
        }

        public static Boolean pesquisar(Cliente c)
        {

            MySqlConnection conn = Conexao.obterConexao();
            string sql = "SELECT * FROM cliente WHERE id = @id";
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
                    c.Email= res["email"].ToString();
                    c.Idade = Convert.ToInt32(res["idade"].ToString());


                    verificar = true;   
                }

            }
            else
            {

                
                verificar= false;

            }
            return verificar;
        }

        public string excluir(string id)
        {
            try
            {
                MySqlConnection conn = Conexao.obterConexao();
                string sql = "DELETE FROM cliente WHERE id = @id";
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

        public static string editar(Cliente cli)
        {

            try
            {

                MySqlConnection conn = Conexao.obterConexao();
                string sql = "UPDATE funcionario SET nome = @nome WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", cli.id);
                cmd.Parameters.AddWithValue("@nome", cli.nome);
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
