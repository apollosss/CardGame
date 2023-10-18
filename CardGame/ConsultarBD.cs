using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class ConsultarBD
    {
        private const string host = "localhost";
        private const string user = "root";
        private const string senha = "";
        private const string database = "gamecard_bd";
        public static string connectionString = $"server={host};database={database};user={user};password={senha};";

        public static DataTable Consultas(string Tabela, string Campos, string Condicao)
        {
            string sql = $"Select {Campos} from {Tabela} WHERE {Condicao}";


            DataTable table = new DataTable();


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();


                MySqlCommand cmd = new MySqlCommand(sql, connection);



                using (MySqlDataReader reader = cmd.ExecuteReader())
                {

                    table.Load(reader); // preenche a tabela 
                }

            }

            return table;
        }
        // ler a tabela retornada,campo por campo e atribuir campo por campo
        // ler a tabela retornada,campo por campo e atribuir campo por campo

        public static DataTable Consultas(string comando)
        {
            DataTable table = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(comando, connection);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    table.Load(reader);
                }

            }
            return table;
        }


        public static void Atualizar(string tabela, string campo, string valorNovo, string condicao)
        {
            string sql = $"UPDATE {tabela} SET {campo} = '{valorNovo}' where {condicao}";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static void Atualizar(string comando)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(comando, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }



    }
}
