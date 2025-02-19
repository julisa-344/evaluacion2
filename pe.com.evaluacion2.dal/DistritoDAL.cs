//using Microsoft.Data.SqlClient;
using pe.com.evaluacion2.bo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.evaluacion2.dal
{
    public class DistritoDAL
    {
        private ConexionDAL objconexion = new ConexionDAL();

        private SqlCommand cmd;

        private SqlDataReader dr;

        int res = 0;

        public List<DistritoBO> MostrarDistrito()
        {
            List<DistritoBO> distritos = new List<DistritoBO>();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarDistrito";
                cmd.Connection = objconexion.Conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DistritoBO obj = new DistritoBO();
                    obj.codigo = Convert.ToInt32(dr["coddis"].ToString());
                    obj.nombre = dr["nomdis"].ToString();
                    obj.estado = Convert.ToBoolean(dr["estdis"].ToString());
                    distritos.Add(obj);
                }
                return distritos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<DistritoBO> MostrarDistritoTodo()
        {
            List<DistritoBO> distritos = new List<DistritoBO>();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarDistritoTodo";
                cmd.Connection = objconexion.Conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DistritoBO obj = new DistritoBO();
                    obj.codigo = Convert.ToInt32(dr["coddis"].ToString());
                    obj.nombre = dr["nomdis"].ToString();
                    obj.estado = Convert.ToBoolean(dr["estdis"].ToString());
                    distritos.Add(obj);
                }
                return distritos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public bool RegistrarDistrito(DistritoBO c)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_RegistrarDistrito";
                cmd.Connection = objconexion.Conectar();
                cmd.Parameters.AddWithValue("@nombre", c.nombre);
                cmd.Parameters.AddWithValue("@estado", c.estado);
                res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                objconexion.CerrarConexion();
            }
        }

        public bool ActualizarDistrito(DistritoBO c)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ActualizarDistrito";
                cmd.Connection = objconexion.Conectar();
                cmd.Parameters.AddWithValue("@codigo", c.codigo);
                cmd.Parameters.AddWithValue("@nombre", c.nombre);
                cmd.Parameters.AddWithValue("@estado", c.estado);
                res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                objconexion.CerrarConexion();
            }
        }

        public bool EliminarDistrito(DistritoBO c)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EliminarDistrito";
                cmd.Connection = objconexion.Conectar();
                cmd.Parameters.AddWithValue("@codigo", c.codigo);
                res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                objconexion.CerrarConexion();
            }
        }
        public bool HabilitarDistrito(DistritoBO c)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_HabilitarDistrito";
                cmd.Connection = objconexion.Conectar();
                cmd.Parameters.AddWithValue("@codigo", c.codigo);
                res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                objconexion.CerrarConexion();
            }
        }

        public int MostrarCodigoDistrito()
        {
            int distritos = 0;
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_CodigoDistrito";
                cmd.Connection = objconexion.Conectar();
                object resultado = cmd.ExecuteScalar();
                if (resultado != null)
                {
                    distritos = (int)resultado;
                }

                return distritos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

    }
}