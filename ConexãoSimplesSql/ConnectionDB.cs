using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexãoSimplesSql
{
    internal class ConnectionDB
    {
        public ConnectionDB()
        {
            // String de conexão com o banco de dados
            string connectionString = "Data Source=DESKTOP-N6OGC4V\\SQLEXPRESS;Initial Catalog=ClientesCadastrados;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexão aberta com sucesso!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao abrir a conexão: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                    Console.WriteLine("Conexão fechada com sucesso!");
                }
            }
        }
    }
}
