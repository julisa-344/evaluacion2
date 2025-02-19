using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using pe.com.evaluacion2.bo;

namespace pe.com.evaluacion2.dal
{
    public class ProductoDAL
    {
        private readonly ConexionDAL objconexion = new ConexionDAL();
        private SqlCommand cmd;
        private SqlDataReader dr;

        // Función para mostrar productos
        private List<ProductoBO> ObtenerProductos(string storedProcedure)
        {
            List<ProductoBO> productos = new List<ProductoBO>();
            try
            {
                cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = storedProcedure,
                    Connection = objconexion.Conectar()
                };

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ProductoBO obj = new ProductoBO
                    {
                        codigo = Convert.ToInt32(dr["codpro"]),
                        nombre = dr["nompro"].ToString(),
                        descripcion = dr["despro"].ToString(),
                        precio = Convert.ToDouble(dr["prepro"]),
                        cantidad = Convert.ToInt32(dr["canpro"]),
                        estado = Convert.ToBoolean(dr["estpro"]) // Cambié "estcat" a "estpro"
                    };

                    // Asignar Marca
                    obj.marca = new MarcaBO
                    {
                        codigo = Convert.ToInt32(dr["codmar"]),
                        nombre = dr["nommar"].ToString()
                    };

                    // Asignar Categoria
                    obj.categoria = new CategoriaBO
                    {
                        codigo = Convert.ToInt32(dr["codcat"]),
                        nombre = dr["nomcat"].ToString()
                    };

                    productos.Add(obj);
                }
                return productos;
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

        // Función para mostrar productos activos
        public List<ProductoBO> MostrarProducto()
        {
            return ObtenerProductos("SP_MostrarProducto");
        }

        // Función para mostrar todos los productos
        public List<ProductoBO> MostrarProductoTodo()
        {
            return ObtenerProductos("SP_MostrarProductoTodo");
        }

        // Función para registrar un producto
        public bool RegistrarProducto(ProductoBO p)
        {
            try
            {
                cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "SP_RegistrarProducto",
                    Connection = objconexion.Conectar()
                };
                cmd.Parameters.AddWithValue("@nombre", p.nombre);
                cmd.Parameters.AddWithValue("@descripcion", p.descripcion);
                cmd.Parameters.AddWithValue("@precio", p.precio);
                cmd.Parameters.AddWithValue("@cantidad", p.cantidad);
                cmd.Parameters.AddWithValue("@estado", p.estado);
                cmd.Parameters.AddWithValue("@codcat", p.categoria.codigo);
                cmd.Parameters.AddWithValue("@codmar", p.marca.codigo);

                return cmd.ExecuteNonQuery() == 1;
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

        // Función para actualizar un producto
        public bool ActualizarProducto(ProductoBO p)
        {
            try
            {
                cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "SP_ActualizarProducto",
                    Connection = objconexion.Conectar()
                };
                cmd.Parameters.AddWithValue("@codigo", p.codigo);
                cmd.Parameters.AddWithValue("@nombre", p.nombre);
                cmd.Parameters.AddWithValue("@descripcion", p.descripcion);
                cmd.Parameters.AddWithValue("@precio", p.precio);
                cmd.Parameters.AddWithValue("@cantidad", p.cantidad);
                cmd.Parameters.AddWithValue("@estado", p.estado);
                cmd.Parameters.AddWithValue("@codcat", p.categoria.codigo);
                cmd.Parameters.AddWithValue("@codmar", p.marca.codigo);

                return cmd.ExecuteNonQuery() == 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                objconexion.CerrarConexion();
            }
        }

        // Función para eliminar un producto
        public bool EliminarProducto(ProductoBO p)
        {
            try
            {
                cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "SP_EliminarProducto",
                    Connection = objconexion.Conectar()
                };
                cmd.Parameters.AddWithValue("@codigo", p.codigo);
                return cmd.ExecuteNonQuery() == 1;
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

        // Función para habilitar un producto
        public bool HabilitarProducto(ProductoBO p)
        {
            try
            {
                cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "SP_HabilitarProducto",
                    Connection = objconexion.Conectar()
                };
                cmd.Parameters.AddWithValue("@codigo", p.codigo);
                return cmd.ExecuteNonQuery() == 1;
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

        // Función para mostrar el código del producto
        public int MostrarCodigoProducto()
        {
            try
            {
                cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "SP_CodigoProducto",
                    Connection = objconexion.Conectar()
                };
                object resultado = cmd.ExecuteScalar();
                return resultado != null ? (int)resultado : 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            finally
            {
                objconexion.CerrarConexion();
            }
        }
    }
}