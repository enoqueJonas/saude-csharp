using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using saude_csharp.Models;
using saude_csharp.Services;

namespace pcsharp_saude.controllers
{
    internal class EspecialidadeController
    {
        public static void Gravar(int id, string designacao)
        {
            SqlConnection conn = Conexao.conectar();
            try
            {
                conn.Open();
                string sqlInsert = "INSERT into especialidades(id, designacao) values(@id,@designacao);";
                SqlCommand command = new SqlCommand(sqlInsert, conn);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@designacao", designacao);
                command.ExecuteNonQuery();
                MessageBox.Show("Especialidade cadastrada com sucesso!");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Não foi possível cadastrar a especialidade");
            }
        }

        public static void Atualizar(int id, string designacao)
        {
            SqlConnection conn = Conexao.conectar();
            try
            {
                conn.Open();
                string sqlUpdate = "UPDATE especialidades SET designacao=@designacao WHERE id=@id";
                SqlCommand command = new SqlCommand(sqlUpdate, conn);
                command.Parameters.AddWithValue("@designacao", designacao);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Não foi possível atualizar a especialidade");
            }
        }

        public static ArrayList Recuperar()
        {
            ArrayList list = new ArrayList();
            SqlConnection conn = Conexao.conectar();
            try
            {
                conn.Open();
                string sqlSelect = "SELECT * from especialidades";
                SqlCommand command = new SqlCommand(sqlSelect, conn);
                SqlDataReader leitor = command.ExecuteReader();
                while (leitor.Read())
                {
                    int id = leitor.GetInt32(0);
                    string designacao = leitor.GetString(1);
                    list.Add(new Especialidade(id, designacao));
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            return list;
        }

        public static ArrayList RecuperarComCod(int cod)
        {
            ArrayList list = new ArrayList();
            SqlConnection conn = Conexao.conectar();
            try
            {
                conn.Open();
                string sqlSelect = "SELECT * from especialidades WHERE id=" + cod;
                SqlCommand command = new SqlCommand(sqlSelect, conn);
                SqlDataReader leitor = command.ExecuteReader();
                while (leitor.Read())
                {
                    int id = leitor.GetInt32(0);
                    string designacao = leitor.GetString(1);
                    list.Add(new Especialidade(id, designacao));
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            return list;
        }

        public static void Remover(int id)
        {
            SqlConnection conn = Conexao.conectar();
            try
            {
                conn.Open();
                string sqlDelete = "DELETE from especialidades WHERE id=@id";
                SqlCommand command = new SqlCommand(sqlDelete, conn);
                command.Parameters.Add(new SqlParameter("@id", id));
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Não foi possível remover a especialidade");
            }
        }
    }
}
