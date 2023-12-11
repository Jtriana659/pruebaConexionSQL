using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaConexion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=SWO5CD2107N47\\SQLV3;Initial Catalog=mvc;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Realiza operaciones con la base de datos aquí
                // Por ejemplo, insertar datos en la tabla 'user'
                InsertarDatos(connection, "correo2@example.com", "contraseña123");

                Console.WriteLine("Datos insertados correctamente.");

                // Puedes realizar otras operaciones o consultas según tus necesidades
            }
        }

        static void InsertarDatos(SqlConnection connection, string correo2, string password)
        {
            string insertQuery = "INSERT INTO [user] (correo, password) VALUES (@correo, @password)";

            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@correo", correo2);
                command.Parameters.AddWithValue("@password", password);
                command.ExecuteNonQuery();
            }
        }
    }
}
