using System.Data.SqlClient;
using saude_csharp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using saude_csharp.Models;

namespace saude_csharp.Controllers
{
    internal class FuncionariosController
    {
        public static int ObterIdUltimoRegisto()
        {
            SqlConnection conn = Conexao.conectar();
            int id = 0;
            try
            {
                conn.Open();
                string sqlSelect = "SELECT TOP 1 * from funcionarios ORDER BY id DESC;";
                SqlCommand command = new SqlCommand(sqlSelect, conn);
                SqlDataReader leitor = command.ExecuteReader();
                while (leitor.Read())
                {
                    id = leitor.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return id;
        }
        public static void Gravar(
            int id,
            int pessoa_id,
            int especialidade,
            string prefixo
        )
        {
            SqlConnection conn = Conexao.conectar();
            int cod = 1;
            try
            {
                conn.Open();
                string sqlInsert = "INSERT into funcionarios(" +
                    "id, " +
                    "pessoa_id, " +
                    "especialidade, " +
                    "prefixo, " +
                    "created_at, " +
                    "updated_at, " +
                    "created_by_utilizador, " +
                    "updated_by_utilizador)" +
                    "values(@id, @pessoa_id, @especialidade, @prefixo, @created_at, @updated_at, @created_by_utilizador, @updated_by_utilizador);";
                SqlCommand command = new SqlCommand(sqlInsert, conn);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@pessoa_id", pessoa_id);
                command.Parameters.AddWithValue("@especialidade", especialidade);
                command.Parameters.AddWithValue("@prefixo", prefixo);
                command.Parameters.AddWithValue("@created_at", DateTime.Now);
                command.Parameters.AddWithValue("@updated_at", DateTime.Now);
                command.Parameters.AddWithValue("created_by_utilizador", cod);
                command.Parameters.AddWithValue("@updated_by_utilizador", cod);
                command.ExecuteNonQuery();
                MessageBox.Show("Funcionario Gravado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void Atualizar(
             int id,
             int pessoa_id,
             int especialidade,
             string prefixo
         )
        {
            SqlConnection conn = Conexao.conectar();
            int cod = 1;
            try
            {
                conn.Open();
                string sqlInsert = "UPDATE funcionarios SET " +
                    "especialidade=@especialidade, " +
                    "prefixo=@prefixo, " +
                    "updated_at=@updated_at," +
                    "updated_by_utilizador=@updated_by_utilizador" +
                    " WHERE id=@id";
                SqlCommand command = new SqlCommand(sqlInsert, conn);
                command.Parameters.AddWithValue("@especialidade", especialidade);
                command.Parameters.AddWithValue("@prefixo", prefixo);
                command.Parameters.AddWithValue("@updated_at", DateTime.Now);
                command.Parameters.AddWithValue("@updated_by_utilizador", cod);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                MessageBox.Show("Funcionario Atualizado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static ArrayList Recuperar()
        {
            ArrayList list = new ArrayList();
            SqlConnection conn = Conexao.conectar();
            try
            {
                conn.Open();
                string sqlSelect = "SELECT * from funcionarios;";
                SqlCommand command = new SqlCommand(sqlSelect, conn);
                SqlDataReader leitor = command.ExecuteReader();
                while (leitor.Read())
                {
                    int id = leitor.GetInt32(0);
                    int pessoa_id = leitor.GetInt32(1);
                    int especialidade = leitor.GetInt32(2);
                    string prefixo = leitor.GetString(3);
                    list.Add(new Funcionario(id, pessoa_id, especialidade, prefixo));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public static ArrayList Recuperar(int cod)
        {
            ArrayList list = new ArrayList();
            SqlConnection conn = Conexao.conectar();
            try
            {
                conn.Open();
                string sqlSelect = "SELECT * from funcionarios WHERE id=" + cod;
                SqlCommand command = new SqlCommand(sqlSelect, conn);
                SqlDataReader leitor = command.ExecuteReader();
                while (leitor.Read())
                {
                    int id = leitor.GetInt32(0);
                    int pessoa_id = leitor.GetInt32(1);
                    int especialidade = leitor.GetInt32(2);
                    string prefixo = leitor.GetString(3);
                    list.Add(new Funcionario(id, pessoa_id, especialidade, prefixo));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public static void Remover(int id)
        {
            SqlConnection conn = Conexao.conectar();
            try
            {
                conn.Open();
                string sqlRemove = "DELETE from funcionarios WHERE id=" + id;
                SqlCommand command = new SqlCommand(sqlRemove, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Funcionario removido!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
