using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using saude_csharp.Services;
using System.Windows.Forms;
using System.Collections;
using saude_csharp.Models;

namespace saude_csharp.controllers
{
    internal class PessoasController
    {
        public static void Gravar(
                int id,
                string nome,
                DateTime data_de_nascimento,
                string sexo,
                string endereco,
                string telefone_1,
                string telefone_2,
                string email
            )
        {
            SqlConnection conn = Conexao.conectar();
            try
            {
                conn.Open();
                string sqlInsert = "INSERT into pessoas(" +
                    "id," +
                    "nome_completo," +
                    "data_de_nascimento," +
                    "sexo," +
                    "endereco," +
                    "telefone_1," +
                    "telefone_2," +
                    "email," +
                    "created_at," +
                    "updated_at," +
                    "created_by_utilizador," +
                    "updated_by_utilizador" +
               ")" +
                    "VALUES(" +
                        "@id, " +
                        "@nome," +
                        "@data," +
                        "@sexo," +
                        "@endereco," +
                        "@telefone_1," +
                        "@telefone_2," +
                        "@email," +
                        "@created_at," +
                        "@updated_at," +
                        "@created_by_utilizador," +
                        "@updated_by_utilizador" +
                     ")";
                SqlCommand command = new SqlCommand(sqlInsert, conn);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@data", data_de_nascimento);
                command.Parameters.AddWithValue("@sexo", sexo);
                command.Parameters.AddWithValue("@endereco", endereco);
                command.Parameters.AddWithValue("@telefone_1", telefone_1);
                command.Parameters.AddWithValue("@telefone_2", telefone_2);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@created_at", DateTime.Now);
                command.Parameters.AddWithValue("@updated_at", DateTime.Now);
                command.Parameters.AddWithValue("created_by_utilizador", 1);
                command.Parameters.AddWithValue("@updated_by_utilizador", 1);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void Atualizar(
                int id,
                string nome,
                DateTime data_de_nascimento,
                string sexo,
                string endereco,
                string telefone_1,
                string telefone_2,
                string email
            )
        {
            SqlConnection conn = Conexao.conectar();
            try
            {
                conn.Open();
                string sqlInsert = "UPDATE pessoas SET " +
                    "nome_completo=@nome_completo," +
                    "data_de_nascimento=@data_de_nascimento," +
                    "sexo=@sexo," +
                    "endereco=@endereco," +
                    "telefone_1=@telefone_1," +
                    "telefone_2=@telefone_2," +
                    "email=@email," +
                    "created_at=@created_at," +
                    "updated_at=@updated_at," +
                    "created_by_utilizador=@created_by_utilizador," +
                    "updated_by_utilizador=@updated_by_utilizador" +
                    " WHERE id=@id";
                SqlCommand command = new SqlCommand(sqlInsert, conn);
                command.Parameters.AddWithValue("@nome_completo", nome);
                command.Parameters.AddWithValue("@data_de_nascimento", data_de_nascimento);
                command.Parameters.AddWithValue("@sexo", sexo);
                command.Parameters.AddWithValue("@endereco", endereco);
                command.Parameters.AddWithValue("@telefone_1", telefone_1);
                command.Parameters.AddWithValue("@telefone_2", telefone_2);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@created_at", DateTime.Now);
                command.Parameters.AddWithValue("@updated_at", DateTime.Now);
                command.Parameters.AddWithValue("created_by_utilizador", 1);
                command.Parameters.AddWithValue("@updated_by_utilizador", 1);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static ArrayList Recuperar()
        {
            SqlConnection conn = Conexao.conectar();
            ArrayList list = new ArrayList();
            try
            {
                conn.Open();
                string sqlSelect = "SELECT * from pessoas";
                SqlCommand command = new SqlCommand(sqlSelect, conn);
                SqlDataReader leitor = command.ExecuteReader();
                while (leitor.Read())
                {
                    int id = leitor.GetInt32(0);
                    string nome = leitor.GetString(1);
                    DateTime dataDeNascimento = leitor.GetDateTime(2);
                    string sexo = leitor.GetString(3);
                    string endereco = leitor.GetString(4);
                    string telefone_1 = leitor.GetString(5);
                    string telefone_2 = leitor.GetString(6);
                    string email = leitor.GetString(7);
                    list.Add(new Pessoa(id, nome, telefone_1, telefone_2, endereco, email, sexo, dataDeNascimento));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public static ArrayList Recuperar(string txt)
        {
            SqlConnection conn = Conexao.conectar();
            ArrayList list = new ArrayList();
            try
            {
                conn.Open();
                string sqlSelect = "SELECT p.id, p.nome_completo, p.data_de_nascimento, p.sexo, p.endereco, p.telefone_1, p.telefone_2, p.email from funcionarios f JOIN pessoas p ON p.id = f.pessoa_id JOIN especialidades d ON f.especialidade = d.id WHERE d.designacao LIKE '%" + txt + "%' OR p.nome_completo LIKE '%" + txt + "%'";
                SqlCommand command = new SqlCommand(sqlSelect, conn);
                SqlDataReader leitor = command.ExecuteReader();
                while (leitor.Read())
                {
                    int id = leitor.GetInt32(0);
                    string nome = leitor.GetString(1);
                    DateTime dataDeNascimento = leitor.GetDateTime(2);
                    string sexo = leitor.GetString(3);
                    string endereco = leitor.GetString(4);
                    string telefone_1 = leitor.GetString(5);
                    string telefone_2 = leitor.GetString(6);
                    string email = leitor.GetString(7);
                    list.Add(new Pessoa(id, nome, telefone_1, telefone_2, endereco, email, sexo, dataDeNascimento));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public static int ObterIdUltimoRegisto()
        {
            SqlConnection conn = Conexao.conectar();
            int id = 0;
            try
            {
                conn.Open();
                string sqlSelect = "SELECT TOP 1 * from pessoas ORDER BY id DESC;";
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

        public static void Remover(int id)
        {
            SqlConnection conn = Conexao.conectar();
            try
            {
                conn.Open();
                string sqlDelete = "DELETE from pessoas WHERE id=" + id;
                SqlCommand command = new SqlCommand(sqlDelete, conn);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static ArrayList Recuperar(int cod)
        {
            SqlConnection conn = Conexao.conectar();
            ArrayList list = new ArrayList();
            try
            {
                conn.Open();
                string sqlSelect = "SELECT * from pessoas WHERE id=" + cod;
                SqlCommand command = new SqlCommand(sqlSelect, conn);
                SqlDataReader leitor = command.ExecuteReader();
                while (leitor.Read())
                {
                    int id = leitor.GetInt32(0);
                    string nome = leitor.GetString(1);
                    DateTime dataDeNascimento = leitor.GetDateTime(2);
                    string sexo = leitor.GetString(3);
                    string endereco = leitor.GetString(4);
                    string telefone_1 = leitor.GetString(5);
                    string telefone_2 = leitor.GetString(6);
                    string email = leitor.GetString(7);
                    list.Add(new Pessoa(id, nome, telefone_1, telefone_2, endereco, email, sexo, dataDeNascimento));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }
    }
}
