using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using pcsharp_saude.Services;

namespace pcsharp_saude.Repositories
{
    public class MedicamentoRepository : BaseRepository
    {
        private static MedicamentoRepository _instance;

        public static MedicamentoRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    return _instance = new MedicamentoRepository();
                }
                else
                {
                    return _instance;
                }
            }
        }

        public Int64 Save(string nome, DateTime dataValidade, string descricao, int quantidade, int createdByUtilizadorId, int unidadeDeMedidaId)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = GetSqlConnection();

            sqlCommand.Parameters.AddWithValue("@nome", nome);
            sqlCommand.Parameters.AddWithValue("@data_validade", dataValidade);
            sqlCommand.Parameters.AddWithValue("@descricao", descricao);
            sqlCommand.Parameters.AddWithValue("@quantidade", quantidade);
            sqlCommand.Parameters.AddWithValue("@created_at", DateTime.Now);
            sqlCommand.Parameters.AddWithValue("@updated_at", DateTime.Now);
            sqlCommand.Parameters.AddWithValue("@created_by_utilizador_id", createdByUtilizadorId);
            sqlCommand.Parameters.AddWithValue("@updated_by_utilizador_id", createdByUtilizadorId);
            sqlCommand.Parameters.AddWithValue("@unidade_de_medida_id", unidadeDeMedidaId);

            sqlCommand.CommandText =
                @"
                INSERT INTO medicamento (nome, data_validade, descricao, quantidade, created_at, updated_at, created_by_utilizador_id, updated_by_utilizador_id, unidade_de_medida_id)
                OUTPUT INSERTED.id
                VALUES (@nome, @data_validade, @descricao, @quantidade, @created_at, @updated_at, @created_by_utilizador_id, @updated_by_utilizador_id, @unidade_de_medida_id)
            ";

            Int64 newId = (Int64)sqlCommand.ExecuteScalar();
            ReturnSqlConnection(sqlCommand.Connection);
            sqlCommand.Dispose();

            return newId;
        }

        public void Update(int id, string nome, DateTime dataValidade, string descricao, int quantidade, int updatedByUtilizadorId, int unidadeDeMedidaId)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = GetSqlConnection();

            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.Parameters.AddWithValue("@nome", nome);
            sqlCommand.Parameters.AddWithValue("@data_validade", dataValidade);
            sqlCommand.Parameters.AddWithValue("@descricao", descricao);
            sqlCommand.Parameters.AddWithValue("@quantidade", quantidade);
            sqlCommand.Parameters.AddWithValue("@updated_at", DateTime.Now);
            sqlCommand.Parameters.AddWithValue("@updated_by_utilizador_id", updatedByUtilizadorId);
            sqlCommand.Parameters.AddWithValue("@unidade_de_medida_id", unidadeDeMedidaId);

            sqlCommand.CommandText =
                @"
                UPDATE medicamento
                SET
                    nome = @nome,
                    data_validade = @data_validade,
                    descricao = @descricao,
                    quantidade = @quantidade,
                    updated_at = @updated_at,
                    updated_by_utilizador_id = @updated_by_utilizador_id,
                    unidade_de_medida_id = @unidade_de_medida_id
                WHERE
                    id = @id
            ";

            sqlCommand.ExecuteNonQuery();
            ReturnSqlConnection(sqlCommand.Connection);
            sqlCommand.Dispose();
        }

        public List<Dictionary<string, object>> FindAll()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = GetSqlConnection();

            sqlCommand.CommandText =
                @"
                SELECT *
                FROM medicamento
            ";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<Dictionary<string, object>> listOfRows = new List<Dictionary<string, object>>();
            while (sqlDataReader.Read())
            {
                Dictionary<string, object> columns = new Dictionary<string, object>();
                columns.Add("id", sqlDataReader.GetValue(0));
                columns.Add("nome", sqlDataReader.GetValue(1));
                columns.Add("data_validade", sqlDataReader.GetValue(2));
                columns.Add("descricao", sqlDataReader.GetValue(3));
                columns.Add("quantidade", sqlDataReader.GetValue(4));
                columns.Add("created_at", sqlDataReader.GetValue(5));
                columns.Add("updated_at", sqlDataReader.GetValue(6));
                columns.Add("created_by_utilizador_id", sqlDataReader.GetValue(7));
                columns.Add("updated_by_utilizador_id", sqlDataReader.GetValue(8));
                columns.Add("unidade_de_medida_id", sqlDataReader.GetValue(9));
                listOfRows.Add(columns);
            }

            ReturnSqlConnection(sqlCommand.Connection);
            sqlCommand.Dispose();

            return listOfRows;
        }

        public Dictionary<string, object> FindById(int id)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = GetSqlConnection();

            sqlCommand.Parameters.AddWithValue("@id", id);

            sqlCommand.CommandText =
                @"
                SELECT *
                FROM medicamento
                WHERE id = @id
            ";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Dictionary<string, object> row = null;
            if (sqlDataReader.Read())
            {
                row = new Dictionary<string, object>();
                row.Add("id", sqlDataReader.GetValue(0));
                row.Add("nome", sqlDataReader.GetValue(1));
                row.Add("data_validade", sqlDataReader.GetValue(2));
                row.Add("descricao", sqlDataReader.GetValue(3));
                row.Add("quantidade", sqlDataReader.GetValue(4));
                row.Add("created_at", sqlDataReader.GetValue(5));
                row.Add("updated_at", sqlDataReader.GetValue(6));
                row.Add("created_by_utilizador_id", sqlDataReader.GetValue(7));
                row.Add("updated_by_utilizador_id", sqlDataReader.GetValue(8));
                row.Add("unidade_de_medida_id", sqlDataReader.GetValue(9));
            }

            ReturnSqlConnection(sqlCommand.Connection);
            sqlCommand.Dispose();

            return row;
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = Conexao.conectar())
            {
                try
                {
                    conn.Open();
                    string sqlDelete = "DELETE FROM medicamento WHERE id = @id";
                    SqlCommand command = new SqlCommand(sqlDelete, conn);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while deleting the medicamento.", ex);
                }
            }
        }
    }
}
