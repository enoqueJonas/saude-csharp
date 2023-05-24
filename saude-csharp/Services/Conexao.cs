using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace saude_csharp.Services
{
    internal class Conexao
    {
        public static string host;
        public static string database;
        public static string user;
        public static string passwd;

        public static SqlConnection conectar()
        {
            SqlConnection conexao = null;
            try
            {
                host = "DESKTOP-06RO7H4\\SQLEXPRESS";
                user = "DESKTOP-06RO7H4\\enoqu";
                passwd = "";
                database = "saude";
                String connection = "Data Source=" + host + ";User id=" + user + ";Password=" + passwd + ";Initial Catalog=" + database + ";Trusted_Connection = True;";
                conexao = new SqlConnection(connection);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Não foi possível conectar a base de dados! Contacte o técnico!");
            }
            finally
            {
                if (conexao != null)
                    conexao.Close();
            }
            return conexao;
        }

    }
}
