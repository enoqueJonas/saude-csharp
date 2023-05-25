using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using pcsharp_saude.Services;

namespace pcsharp_saude.Repositories
{
    public class ReceitaRepository : BaseRepository
    {
        private static ReceitaRepository _instance;

        public static ReceitaRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    return _instance = new ReceitaRepository();
                }
                else
                {
                    return _instance;
                }
            }
        }

        public Int64 Save(int? consultaId, int? createdByUtilizadorId, List<int> medicamentoIds)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = GetSqlConnection();

            sqlCommand.Parameters.AddWithValue("@consulta_id", convertToDBNullIfNull(consultaId));
            sqlCommand.Parameters.AddWithValue("@created_at", convertToDBNullIfNull(DateTime.Now));
            sqlCommand.Parameters.AddWithValue("@created_by_utilizador_id", convertToDBNullIfNull(createdByUtilizadorId));

            sqlCommand.CommandText =
                @"
        INSERT INTO receita (consulta_id, created_at, created_by_utilizador_id)
        OUTPUT INSERTED.ID
        VALUES(@consulta_id, @created_at, @created_by_utilizador_id)
    ";

            Int64 newId = (Int64)sqlCommand.ExecuteScalar();

            
            if (medicamentoIds != null && medicamentoIds.Count > 0)
            {
                using (SqlCommand medicamentosCommand = new SqlCommand())
                {
                    medicamentosCommand.Connection = GetSqlConnection();
                    medicamentosCommand.CommandText = @"
                INSERT INTO receita_medicamentos (receita_id, medicamento_id)
                VALUES (@receita_id, @medicamento_id)";

                    SqlParameter receitaIdParameter = new SqlParameter("@receita_id", newId);
                    medicamentosCommand.Parameters.Add(receitaIdParameter);
                    SqlParameter medicamentoIdParameter = new SqlParameter("@medicamento_id", System.Data.SqlDbType.Int);
                    medicamentosCommand.Parameters.Add(medicamentoIdParameter);

                    foreach (int medicamentoId in medicamentoIds)
                    {
                        medicamentoIdParameter.Value = medicamentoId;
                        medicamentosCommand.ExecuteNonQuery();
                    }
                }
            }

            ReturnSqlConnection(sqlCommand.Connection);
            sqlCommand.Dispose();

            return newId;
        }


        public void Update(int id, int consultaId, DateTime data, int updatedByUtilizadorId)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = GetSqlConnection();

            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.Parameters.AddWithValue("@consulta_id", consultaId);
            sqlCommand.Parameters.AddWithValue("@updated_at", DateTime.Now);
            sqlCommand.Parameters.AddWithValue("@updated_by_utilizador_id", updatedByUtilizadorId);

            sqlCommand.CommandText =
                @"
                UPDATE receita 
                SET 
                    consulta_id = @consulta_id,
                    updated_at = @updated_at, 
                    updated_by_utilizador_id = @updated_by_utilizador_id
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
                FROM receita
            ";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<Dictionary<string, object>> listOfRows = new List<Dictionary<string, object>>();
            while (sqlDataReader.Read())
            {
                Dictionary<string, object> columns = new Dictionary<string, object>();
                columns.Add("id", sqlDataReader.GetValue(0));
                columns.Add("consulta_id", sqlDataReader.GetValue(1));
                columns.Add("created_at", sqlDataReader.GetValue(2));
                columns.Add("updated_at", sqlDataReader.GetValue(3));
                columns.Add("created_by_utilizador_id", sqlDataReader.GetValue(4));
                columns.Add("updated_by_utilizador_id", sqlDataReader.GetValue(5));
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
                FROM receita
                WHERE id = @id
            ";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Dictionary<string, object> row = null;
            if (sqlDataReader.Read())
            {
                row = new Dictionary<string, object>();
                row.Add("id", sqlDataReader.GetValue(0));
                row.Add("consulta_id", sqlDataReader.GetValue(1));
                row.Add("created_at", sqlDataReader.GetValue(2));
                row.Add("updated_at", sqlDataReader.GetValue(3));
                row.Add("created_by_utilizador_id", sqlDataReader.GetValue(4));
                row.Add("updated_by_utilizador_id", sqlDataReader.GetValue(5));
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
                    string sqlDelete = "DELETE FROM receitas WHERE Id = @Id;";
                    SqlCommand command = new SqlCommand(sqlDelete, conn);
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while deleting the receita.", ex);
                }
            }
        }
    }
}
