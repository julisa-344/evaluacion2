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
    public class EmpleadoDAL
    {
        private ConexionDAL objconexion = new ConexionDAL();
        private SqlCommand cmd;
        private SqlDataReader dr;
        int res = 0;

        //funcion para mostrar la Empleado
        public List<EmpleadoBO> MostrarEmpleado()
        {
            List<EmpleadoBO> empleados = new List<EmpleadoBO>();
            SqlDataReader dr = null;

            try
            {
                // Establecer el comando y la conexión
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarEmpleado";
                cmd.Connection = objconexion.Conectar();

                // Ejecutar el reader
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    EmpleadoBO obj = new EmpleadoBO();
                    DistritoBO objDistrito = new DistritoBO();
                    RolBO objRol = new RolBO();
                    TipoDocumentoBO objTipoDocumento = new TipoDocumentoBO();

                    // Asignar propiedades del empleado
                    obj.codigo = Convert.ToInt32(dr["codemp"]);
                    obj.nombre = dr["nomemp"].ToString();
                    obj.apellidoPaterno = dr["apepemp"].ToString();
                    obj.apellidoMaterno = dr["apememp"].ToString();
                    obj.documento = dr["docemp"].ToString();
                    obj.direccion = dr["diremp"].ToString();
                    obj.telefono = dr["telemp"].ToString();
                    obj.celular = dr["celemp"].ToString();
                    obj.correoElectronico = dr["coremp"].ToString();
                    obj.usuario = dr["usuemp"].ToString();
                    obj.clave = dr["claemp"].ToString();
                    obj.estado = Convert.ToBoolean(dr["estemp"]);

                    // Asignar distrito
                    objDistrito.codigo = Convert.ToInt32(dr["coddis"]);
                    objDistrito.nombre = dr["nomdis"].ToString(); // Asegúrate que estos campos existen
                    obj.distrito = objDistrito;

                    // Asignar rol
                    objRol.codigo = Convert.ToInt32(dr["codrol"]);
                    objRol.nombre = dr["nomrol"].ToString();
                    obj.rol = objRol;

                    // Asignar tipo de documento
                    objTipoDocumento.codigo = Convert.ToInt32(dr["codtipd"]);
                    objTipoDocumento.nombre = dr["nomtipd"].ToString();
                    obj.TipoDocumento = objTipoDocumento;

                    // Agregar el objeto a la lista
                    empleados.Add(obj);
                }

                // Devolvemos la lista de empleados
                return empleados;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                // Asegúrate de cerrar el DataReader y la conexión
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }

                if (cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
        }

        //funcion para mostrar la categoria
        public List<EmpleadoBO> MostrarEmpleadoTodo()
        {
            List<EmpleadoBO> empleados = new List<EmpleadoBO>();
            SqlDataReader dr = null;

            try
            {
                // Establecer el comando y la conexión
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarEmpleadoTodo";
                cmd.Connection = objconexion.Conectar();

                // Ejecutar el reader
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    EmpleadoBO obj = new EmpleadoBO();
                    DistritoBO objDistrito = new DistritoBO();
                    RolBO objRol = new RolBO();
                    TipoDocumentoBO objTipoDocumento = new TipoDocumentoBO();

                    // Asignar propiedades del empleado
                    obj.codigo = Convert.ToInt32(dr["codemp"]);
                    obj.nombre = dr["nomemp"].ToString();
                    obj.apellidoPaterno = dr["apepemp"].ToString();
                    obj.apellidoMaterno = dr["apememp"].ToString();
                    obj.documento = dr["docemp"].ToString();
                    obj.direccion = dr["diremp"].ToString();
                    obj.telefono = dr["telemp"].ToString();
                    obj.celular = dr["celemp"].ToString();
                    obj.correoElectronico = dr["coremp"].ToString();
                    obj.usuario = dr["usuemp"].ToString();
                    obj.clave = dr["claemp"].ToString();
                    obj.estado = Convert.ToBoolean(dr["estemp"]);

                    // Asignar distrito
                    objDistrito.codigo = Convert.ToInt32(dr["coddis"]);
                    objDistrito.nombre = dr["nomdis"].ToString(); // Asegúrate que estos campos existen
                    obj.distrito = objDistrito;

                    // Asignar rol
                    objRol.codigo = Convert.ToInt32(dr["codrol"]);
                    objRol.nombre = dr["nomrol"].ToString();
                    obj.rol = objRol;

                    // Asignar tipo de documento
                    objTipoDocumento.codigo = Convert.ToInt32(dr["codtipd"]);
                    objTipoDocumento.nombre = dr["nomtipd"].ToString();
                    obj.TipoDocumento = objTipoDocumento;

                    // Agregar el objeto a la lista
                    empleados.Add(obj);
                }

                // Devolvemos la lista de empleados
                return empleados;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                // Asegúrate de cerrar el DataReader y la conexión
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }

                if (cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
        }

        //creamos una funcion para registrar
        public bool RegistrarEmpleado(EmpleadoBO p)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_RegistrarEmpleado";
                cmd.Connection = objconexion.Conectar();

                // Agregar los parámetros correctos para el registro de un empleado
                cmd.Parameters.AddWithValue("@nombre", p.nombre);
                cmd.Parameters.AddWithValue("@apellidoPaterno", p.apellidoPaterno);
                cmd.Parameters.AddWithValue("@apellidoMaterno", p.apellidoMaterno);
                cmd.Parameters.AddWithValue("@documento", p.documento);
                cmd.Parameters.AddWithValue("@direccion", p.direccion);
                cmd.Parameters.AddWithValue("@telefono", p.telefono);
                cmd.Parameters.AddWithValue("@celular", p.celular);
                cmd.Parameters.AddWithValue("@correoElectronico", p.correoElectronico);
                cmd.Parameters.AddWithValue("@usuario", p.usuario);
                cmd.Parameters.AddWithValue("@clave", p.clave);
                cmd.Parameters.AddWithValue("@estado", p.estado);

                // Agregar parámetros para el distrito, rol y tipo de documento si los tienes
                cmd.Parameters.AddWithValue("@coddis", p.distrito.codigo);
                cmd.Parameters.AddWithValue("@codrol", p.rol.codigo);
                cmd.Parameters.AddWithValue("@codtipd", p.TipoDocumento.codigo);

                // Ejecutar la consulta
                int res = cmd.ExecuteNonQuery();

                // Verificar si el registro fue exitoso
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
        public bool ActualizarEmpleado(EmpleadoBO p)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ActualizarEmpleado";
                cmd.Connection = objconexion.Conectar();

                // Agregar los parámetros correctos para la actualización de un empleado
                cmd.Parameters.AddWithValue("@codigo", p.codigo);
                cmd.Parameters.AddWithValue("@nombre", p.nombre);
                cmd.Parameters.AddWithValue("@apellidoPaterno", p.apellidoPaterno);
                cmd.Parameters.AddWithValue("@apellidoMaterno", p.apellidoMaterno);
                cmd.Parameters.AddWithValue("@documento", p.documento);
                cmd.Parameters.AddWithValue("@direccion", p.direccion);
                cmd.Parameters.AddWithValue("@telefono", p.telefono);
                cmd.Parameters.AddWithValue("@celular", p.celular);
                cmd.Parameters.AddWithValue("@correoElectronico", p.correoElectronico);
                cmd.Parameters.AddWithValue("@usuario", p.usuario);
                cmd.Parameters.AddWithValue("@clave", p.clave);
                cmd.Parameters.AddWithValue("@estado", p.estado);

                // Agregar parámetros para el distrito, rol y tipo de documento si es necesario
                cmd.Parameters.AddWithValue("@coddis", p.distrito.codigo);
                cmd.Parameters.AddWithValue("@codrol", p.rol.codigo);
                cmd.Parameters.AddWithValue("@codtipd", p.TipoDocumento.codigo);

                // Ejecutar la consulta
                int res = cmd.ExecuteNonQuery();

                // Verificar si la actualización fue exitosa
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

        //creamos una funcion para eliminar
        public bool EliminarEmpleado(EmpleadoBO p)
        {
            try
            {
                // Crear y configurar el comando SQL
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EliminarEmpleado";
                cmd.Connection = objconexion.Conectar();

                // Agregar el parámetro para el código del empleado
                cmd.Parameters.AddWithValue("@codigo", p.codigo);

                // Ejecutar la eliminación
                int res = cmd.ExecuteNonQuery();

                // Verificar si se realizó correctamente la eliminación
                if (res == 1)
                {
                    return true;  // Se eliminó correctamente
                }
                else
                {
                    return false;  // No se eliminó
                }
            }
            catch (SqlException ex)
            {
                // Manejo de excepciones
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                // Cerrar la conexión
                objconexion.CerrarConexion();
            }
        }

        //creamos una funcion para habilitar
        public bool HabilitarEmpleado(EmpleadoBO p)
        {
            try
            {
                // Crear y configurar el comando SQL
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_HabilitarEmpleado";
                cmd.Connection = objconexion.Conectar();

                // Agregar el parámetro para el código del empleado
                cmd.Parameters.AddWithValue("@codigo", p.codigo);

                // Ejecutar la habilitación
                int res = cmd.ExecuteNonQuery();

                // Verificar si se realizó correctamente la habilitación
                if (res == 1)
                {
                    return true;  // El empleado fue habilitado correctamente
                }
                else
                {
                    return false;  // No se habilitó el empleado
                }
            }
            catch (SqlException ex)
            {
                // Manejo de excepciones
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                // Cerrar la conexión
                objconexion.CerrarConexion();
            }
        }

        //funcion para mostrar la categoria
        public int MostrarCodigoEmpleado()
        {
            int codigoEmpleado = 0;
            try
            {
                // Crear y configurar el comando SQL
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_CodigoEmpleado";
                cmd.Connection = objconexion.Conectar();

                // Ejecutar el comando y obtener el valor retornado
                object resultado = cmd.ExecuteScalar();

                // Verificar si el resultado es nulo
                if (resultado != null && resultado != DBNull.Value)
                {
                    // Convertir el resultado a un entero
                    codigoEmpleado = Convert.ToInt32(resultado);
                }

                // Retornar el código del empleado
                return codigoEmpleado;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine(ex.Message);
                return 0;  // Retorna 0 en caso de error
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                objconexion.CerrarConexion();
            }
        }
    }
}