using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.com.evaluacion2.bo;

namespace pe.com.evaluacion2.dal
{
    public class TipoDocumentoDAL
    {
        private ConexionDAL objconexion = new ConexionDAL();
        private SqlCommand cmd;
        private SqlDataReader dr;
        int res = 0;

        //funcion para mostrar la TipoDocumento
        public List<TipoDocumentoBO> MostrarTipoDocumento()
        {
            List<TipoDocumentoBO> tipoDocumentos = new List<TipoDocumentoBO>();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarTipoDocumento";
                cmd.Connection = objconexion.Conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TipoDocumentoBO obj = new TipoDocumentoBO();
                    obj.codigo = Convert.ToInt32(dr["codmar"].ToString());
                    obj.nombre = dr["nommar"].ToString();
                    obj.estado = Convert.ToBoolean(dr["estmar"].ToString());
                    tipoDocumentos.Add(obj);
                }
                return tipoDocumentos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                objconexion.CerrarConexion();
            }
        }

        //funcion para mostrar la TipoDocumento
        public List<TipoDocumentoBO> MostrarTipoDocumentoTodo()
        {
            List<TipoDocumentoBO> tipoDocumentos = new List<TipoDocumentoBO>();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarTipoDocumentoTodo";
                cmd.Connection = objconexion.Conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TipoDocumentoBO obj = new TipoDocumentoBO();
                    obj.codigo = Convert.ToInt32(dr["codmar"].ToString());
                    obj.nombre = dr["nommar"].ToString();
                    obj.estado = Convert.ToBoolean(dr["estmar"].ToString());
                    tipoDocumentos.Add(obj);
                }
                return tipoDocumentos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                objconexion.CerrarConexion();
            }
        }
        //creamos una funcion para registrar
        public bool RegistrarTipoDocumento(TipoDocumentoBO c)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_RegistrarTipoDocumento";
                cmd.Connection = objconexion.Conectar();
                //pasamos los datos que registraremos por parametros
                cmd.Parameters.AddWithValue("@nombre", c.nombre);
                cmd.Parameters.AddWithValue("@estado", c.estado);
                //ejecutamos el procedimiento almacenado
                res = cmd.ExecuteNonQuery();
                //evaluamos
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

        //creamos una funcion para actualizar
        public bool ActualizarTipoDocumento(TipoDocumentoBO c)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ActualizarTipoDocumento";
                cmd.Connection = objconexion.Conectar();
                //pasamos los datos que registraremos por parametros
                cmd.Parameters.AddWithValue("@codigo", c.codigo);
                cmd.Parameters.AddWithValue("@nombre", c.nombre);
                cmd.Parameters.AddWithValue("@estado", c.estado);
                //ejecutamos el procedimiento almacenado
                res = cmd.ExecuteNonQuery();
                //evaluamos
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

        //creamos una funcion para actualizar
        public bool EliminarTipoDocumento(TipoDocumentoBO c)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EliminarTipoDocumento";
                cmd.Connection = objconexion.Conectar();
                //pasamos los datos que registraremos por parametros
                cmd.Parameters.AddWithValue("@codigo", c.codigo);
                //ejecutamos el procedimiento almacenado
                res = cmd.ExecuteNonQuery();
                //evaluamos
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
        //creamos una funcion para habilitar
        public bool HabilitarTipoDocumento(TipoDocumentoBO c)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_HabilitarTipoDocumento";
                cmd.Connection = objconexion.Conectar();
                //pasamos los datos que registraremos por parametros
                cmd.Parameters.AddWithValue("@codigo", c.codigo);
                //ejecutamos el procedimiento almacenado
                res = cmd.ExecuteNonQuery();
                //evaluamos
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

        //funcion para mostrar la TipoDocumento
        public int MostrarCodigoTipoDocumento()
        {
            //creamos una lista de tipo TipoDocumentoBO
            int tipoDocumentos = 0;
            try
            {
                //instanciamos el SQLCommand
                cmd = new SqlCommand();
                //especificamos el tipo de SQLCommand
                cmd.CommandType = CommandType.StoredProcedure;
                //especificamos el nombre del procedimiento
                cmd.CommandText = "SP_CodigoTipoDocumento";
                //instanciamos la conexion
                cmd.Connection = objconexion.Conectar();
                //ejecutamos la consulta y guardamos el resultado en el SQLDataReader
                object resultado = cmd.ExecuteScalar();
                if (resultado != null)
                {
                    tipoDocumentos = (int)resultado;
                }

                //devolvemos la lista
                return tipoDocumentos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

    }
}