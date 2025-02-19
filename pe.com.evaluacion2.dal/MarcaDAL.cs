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
    public class MarcaDAL
    {
        private ConexionDAL objconexion = new ConexionDAL();
        private SqlCommand cmd;
        private SqlDataReader dr;
        int res = 0;

        //funcion para mostrar la Marca
        public List<MarcaBO> MostrarMarca()
        {
            List<MarcaBO> marcas = new List<MarcaBO>();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarMarca";
                cmd.Connection = objconexion.Conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MarcaBO obj = new MarcaBO();
                    obj.codigo = Convert.ToInt32(dr["codmar"].ToString());
                    obj.nombre = dr["nommar"].ToString();
                    obj.estado = Convert.ToBoolean(dr["estmar"].ToString());
                    marcas.Add(obj);
                }
                return marcas;
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

        //funcion para mostrar la Marca
        public List<MarcaBO> MostrarMarcaTodo()
        {
            List<MarcaBO> marcas = new List<MarcaBO>();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarMarcaTodo";
                cmd.Connection = objconexion.Conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MarcaBO obj = new MarcaBO();
                    obj.codigo = Convert.ToInt32(dr["codmar"].ToString());
                    obj.nombre = dr["nommar"].ToString();
                    obj.estado = Convert.ToBoolean(dr["estmar"].ToString());
                    marcas.Add(obj);
                }
                return marcas;
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
        public bool RegistrarMarca(MarcaBO c)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_RegistrarMarca";
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
        public bool ActualizarMarca(MarcaBO c)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ActualizarMarca";
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
        public bool EliminarMarca(MarcaBO c)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EliminarMarca";
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
        public bool HabilitarMarca(MarcaBO c)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_HabilitarMarca";
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

        //funcion para mostrar la Marca
        public int MostrarCodigoMarca()
        {
            //creamos una lista de tipo MarcaBO
            int marcas = 0;
            try
            {
                //instanciamos el SQLCommand
                cmd = new SqlCommand();
                //especificamos el tipo de SQLCommand
                cmd.CommandType = CommandType.StoredProcedure;
                //especificamos el nombre del procedimiento
                cmd.CommandText = "SP_CodigoMarca";
                //instanciamos la conexion
                cmd.Connection = objconexion.Conectar();
                //ejecutamos la consulta y guardamos el resultado en el SQLDataReader
                object resultado = cmd.ExecuteScalar();
                if (resultado != null)
                {
                    marcas = (int)resultado;
                }

                //devolvemos la lista
                return marcas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

    }
}