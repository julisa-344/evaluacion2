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
    public class ClienteDAL
    {
        private ConexionDAL objconexion = new ConexionDAL();
        private SqlCommand cmd;
        private SqlDataReader dr;
        int res = 0;

        //funcion para mostrar la Cliente
        public List<ClienteBO> MostrarCliente()
        {
            List<ClienteBO> clientes = new List<ClienteBO>();
            SqlDataReader dr = null;

            try
            {
                // Establecer el comando y la conexión
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarCliente";
                cmd.Connection = objconexion.Conectar();

                // Ejecutar el reader
                dr = cmd.ExecuteReader();
                System.Diagnostics.Debug.WriteLine("Records returned: " + dr.HasRows);

                while (dr.Read())
                {
                    ClienteBO obj = new ClienteBO();
                    DistritoBO objDistrito = new DistritoBO();
                    RolBO objRol = new RolBO();
                    TipoDocumentoBO objTipoDocumento = new TipoDocumentoBO();

                    // Asignar propiedades del Cliente
                    obj.codigo = Convert.ToInt32(dr["codcli"]);
                    obj.nombre = dr["nomcli"].ToString();
                    obj.apellidoPaterno = dr["apepcli"].ToString();
                    obj.apellidoMaterno = dr["apemcli"].ToString();
                    obj.documento = dr["doccli"].ToString();
                    obj.direccion = dr["dircli"].ToString();
                    obj.telefono = dr["telcli"].ToString();
                    obj.celular = dr["celcli"].ToString();
                    obj.correoElectronico = dr["corcli"].ToString();
                    obj.estado = Convert.ToBoolean(dr["estcli"]);

                    // Asignar distrito
                    objDistrito.codigo = Convert.ToInt32(dr["coddis"]);
                    objDistrito.nombre = dr["nomdis"].ToString(); // Asegúrate que estos campos existen
                    obj.distrito = objDistrito;

                    // Asignar tipo de documento
                    objTipoDocumento.codigo = Convert.ToInt32(dr["codtipd"]);
                    objTipoDocumento.nombre = dr["nomtipd"].ToString();
                    obj.TipoDocumento = objTipoDocumento;

                    // Agregar el objeto a la lista
                    clientes.Add(obj);
                }

                // Devolvemos la lista de clientes
                return clientes;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                //Console.WriteLine(ex.Message);
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
        public List<ClienteBO> MostrarClienteTodo()
        {
            List<ClienteBO> clientes = new List<ClienteBO>();
            SqlDataReader dr = null;

            try
            {
                // Establecer el comando y la conexión
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarClienteTodo";
                cmd.Connection = objconexion.Conectar();
                System.Diagnostics.Debug.WriteLine("exito");

                // Ejecutar el reader
                dr = cmd.ExecuteReader();
                System.Diagnostics.Debug.WriteLine("perro");

                while (dr.Read())
                {
                    ClienteBO obj = new ClienteBO();
                    DistritoBO objDistrito = new DistritoBO();
                    RolBO objRol = new RolBO();
                    TipoDocumentoBO objTipoDocumento = new TipoDocumentoBO();
                    System.Diagnostics.Debug.WriteLine("perro 3");

                    // Asignar propiedades del Cliente
                    obj.codigo = Convert.ToInt32(dr["codcli"]);
                    obj.nombre = dr["nomcli"].ToString();
                    obj.apellidoPaterno = dr["apepcli"].ToString();
                    obj.apellidoMaterno = dr["apemcli"].ToString();
                    obj.documento = dr["doccli"].ToString();
                    obj.direccion = dr["dircli"].ToString();
                    obj.telefono = dr["telcli"].ToString();
                    obj.celular = dr["celcli"].ToString();
                    obj.correoElectronico = dr["corcli"].ToString();
                    obj.estado = Convert.ToBoolean(dr["estcli"]);
                    System.Diagnostics.Debug.WriteLine("perro 4");

                    // Asignar distrito
                    objDistrito.codigo = Convert.ToInt32(dr["coddis"]);
                    objDistrito.nombre = dr["nomdis"].ToString(); // Asegúrate que estos campos existen
                    obj.distrito = objDistrito;
                    System.Diagnostics.Debug.WriteLine("perro 5");

                    // Asignar tipo de documento
                    objTipoDocumento.codigo = Convert.ToInt32(dr["codtipd"]);
                    objTipoDocumento.nombre = dr["nomtipd"].ToString();
                    obj.TipoDocumento = objTipoDocumento;
                    System.Diagnostics.Debug.WriteLine("perro 6");

                    // Agregar el objeto a la lista
                    clientes.Add(obj);
                }

                // Devolvemos la lista de clientes
                return clientes;
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
        public bool RegistrarCliente(ClienteBO p)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_RegistrarCliente";
                cmd.Connection = objconexion.Conectar();

                // Agregar los parámetros correctos para el registro de un Cliente
                cmd.Parameters.AddWithValue("@nombre", p.nombre);
                cmd.Parameters.AddWithValue("@apellidoPaterno", p.apellidoPaterno);
                cmd.Parameters.AddWithValue("@apellidoMaterno", p.apellidoMaterno);
                cmd.Parameters.AddWithValue("@documento", p.documento);
                cmd.Parameters.AddWithValue("@direccion", p.direccion);
                cmd.Parameters.AddWithValue("@telefono", p.telefono);
                cmd.Parameters.AddWithValue("@celular", p.celular);
                cmd.Parameters.AddWithValue("@correoElectronico", p.correoElectronico);
                cmd.Parameters.AddWithValue("@estado", p.estado);

                // Agregar parámetros para el distrito, rol y tipo de documento si los tienes
                cmd.Parameters.AddWithValue("@coddis", p.distrito.codigo);
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
        public bool ActualizarCliente(ClienteBO p)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ActualizarCliente";
                cmd.Connection = objconexion.Conectar();

                // Agregar los parámetros correctos para la actualización de un Cliente
                cmd.Parameters.AddWithValue("@codigo", p.codigo);
                cmd.Parameters.AddWithValue("@nombre", p.nombre);
                cmd.Parameters.AddWithValue("@apellidoPaterno", p.apellidoPaterno);
                cmd.Parameters.AddWithValue("@apellidoMaterno", p.apellidoMaterno);
                cmd.Parameters.AddWithValue("@documento", p.documento);
                cmd.Parameters.AddWithValue("@direccion", p.direccion);
                cmd.Parameters.AddWithValue("@telefono", p.telefono);
                cmd.Parameters.AddWithValue("@celular", p.celular);
                cmd.Parameters.AddWithValue("@correoElectronico", p.correoElectronico);
                cmd.Parameters.AddWithValue("@estado", p.estado);

                // Agregar parámetros para el distrito, rol y tipo de documento si es necesario
                cmd.Parameters.AddWithValue("@coddis", p.distrito.codigo);
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
        public bool EliminarCliente(ClienteBO p)
        {
            try
            {
                // Crear y configurar el comando SQL
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EliminarCliente";
                cmd.Connection = objconexion.Conectar();

                // Agregar el parámetro para el código del Cliente
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
        public bool HabilitarCliente(ClienteBO p)
        {
            try
            {
                // Crear y configurar el comando SQL
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_HabilitarCliente";
                cmd.Connection = objconexion.Conectar();

                // Agregar el parámetro para el código del Cliente
                cmd.Parameters.AddWithValue("@codigo", p.codigo);

                // Ejecutar la habilitación
                int res = cmd.ExecuteNonQuery();

                // Verificar si se realizó correctamente la habilitación
                if (res == 1)
                {
                    return true;  // El Cliente fue habilitado correctamente
                }
                else
                {
                    return false;  // No se habilitó el Cliente
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
        public int MostrarCodigoCliente()
        {
            int codigoCliente = 0;
            try
            {
                // Crear y configurar el comando SQL
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_CodigoCliente";
                cmd.Connection = objconexion.Conectar();

                // Ejecutar el comando y obtener el valor retornado
                object resultado = cmd.ExecuteScalar();

                // Verificar si el resultado es nulo
                if (resultado != null && resultado != DBNull.Value)
                {
                    // Convertir el resultado a un entero
                    codigoCliente = Convert.ToInt32(resultado);
                }

                // Retornar el código del Cliente
                return codigoCliente;
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