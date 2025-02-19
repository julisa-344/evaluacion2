using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

public class UsuarioBAL
{
    private String connectionString = "Data Source=.; Initial Catalog=bdciberelectrik2025; Integrated Security=True";

    public bool ValidarUsuario(string nombreUsuario, string clave)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM usuarios WHERE nombre_usuario = @nombreUsuario AND clave = @clave";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@clave", clave); // Asegúrate de que la clave esté encriptada si es necesario

                int count = (int)cmd.ExecuteScalar();
                return count > 0; // Retorna true si el usuario existe
            }
        }
    }
}