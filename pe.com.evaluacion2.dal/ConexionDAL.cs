using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.evaluacion2.dal
{
    public class ConexionDAL
    {
        private String cadena = "Data Source=.; Initial Catalog=bdciberelectrik2025; Integrated Security=True";

        private SqlConnection xcon;

        public SqlConnection Conectar()
        {
            xcon = new SqlConnection(cadena);
            xcon.Open();
            return xcon;
        }

        public void CerrarConexion()
        {
            xcon.Close();
            xcon.Dispose();
        }
    }
}
