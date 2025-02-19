//using Microsoft.Data.SqlClient;
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
    public class RolDAL
    {
        //crear un objeto de la clase Conexion
        private ConexionDAL objconexion = new ConexionDAL();

        //comando SQL
        private SqlCommand cmd;

        //lectura de datos
        private SqlDataReader dr;

        //creamos una variable para los resultados de SQL de actualizacion
        int res = 0;

        //funcion para mostrar la Rol
        public List<RolBO> MostrarRol()
        {
            //creamos una lista de tipo RolBO
            List<RolBO> rols = new List<RolBO>();
            try
            {
                //instanciamos el SQLCommand
                cmd = new SqlCommand();
                //especificamos el tipo de SQLCommand
                cmd.CommandType = CommandType.StoredProcedure;
                //especificamos el nombre del procedimiento
                cmd.CommandText = "SP_MostrarRol";
                //instanciamos la conexion
                cmd.Connection = objconexion.Conectar();
                //ejecutamos la consulta y guardamos el resultado en el SQLDataReader
                dr = cmd.ExecuteReader();
                //cargamos los datos del SQLDataReader en la lista
                while (dr.Read())
                {
                    //creamos un objeto de tipo RolBO
                    RolBO obj = new RolBO();
                    //leemos los datos y los asignamos al objeto
                    obj.codigo = Convert.ToInt32(dr["codrol"].ToString());
                    obj.nombre = dr["nomrol"].ToString();
                    obj.estado = Convert.ToBoolean(dr["estrol"].ToString());
                    //agregar el objeto a la lista
                    rols.Add(obj);
                }
                //devolvemos la lista
                return rols;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //funcion para mostrar la Rol
        public List<RolBO> MostrarRolTodo()
        {
            //creamos una lista de tipo RolBO
            List<RolBO> rols = new List<RolBO>();
            try
            {
                //instanciamos el SQLCommand
                cmd = new SqlCommand();
                //especificamos el tipo de SQLCommand
                cmd.CommandType = CommandType.StoredProcedure;
                //especificamos el nombre del procedimiento
                cmd.CommandText = "SP_MostrarRolTodo";
                //instanciamos la conexion
                cmd.Connection = objconexion.Conectar();
                //ejecutamos la consulta y guardamos el resultado en el SQLDataReader
                dr = cmd.ExecuteReader();
                //cargamos los datos del SQLDataReader en la lista
                while (dr.Read())
                {
                    //creamos un objeto de tipo RolBO
                    RolBO obj = new RolBO();
                    //leemos los datos y los asignamos al objeto
                    obj.codigo = Convert.ToInt32(dr["codrol"].ToString());
                    obj.nombre = dr["nomrol"].ToString();
                    obj.estado = Convert.ToBoolean(dr["estrol"].ToString());
                    //agregar el objeto a la lista
                    rols.Add(obj);
                }
                //devolvemos la lista
                return rols;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //creamos una funcion para registrar
        public bool RegistrarRol(RolBO c)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_RegistrarRol";
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
        public bool ActualizarRol(RolBO c)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ActualizarRol";
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
        public bool EliminarRol(RolBO c)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EliminarRol";
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
        public bool HabilitarRol(RolBO c)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_HabilitarRol";
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

        //funcion para mostrar la Rol
        public int MostrarCodigoRol()
        {
            //creamos una lista de tipo RolBO
            int rols = 0;
            try
            {
                //instanciamos el SQLCommand
                cmd = new SqlCommand();
                //especificamos el tipo de SQLCommand
                cmd.CommandType = CommandType.StoredProcedure;
                //especificamos el nombre del procedimiento
                cmd.CommandText = "SP_CodigoRol";
                //instanciamos la conexion
                cmd.Connection = objconexion.Conectar();
                //ejecutamos la consulta y guardamos el resultado en el SQLDataReader
                object resultado = cmd.ExecuteScalar();
                if (resultado != null)
                {
                    rols = (int)resultado;
                }

                //devolvemos la lista
                return rols;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

    }
}