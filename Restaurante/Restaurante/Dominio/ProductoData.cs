using Restaurante.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurante.Dominio;
using Restaurante.Datos;
using MySql.Data.MySqlClient;
using System.Collections;
using Restaurante.Modelos;
using System.Windows.Forms;

namespace Restaurante.Dominio
{
    internal class ProductoData : IProductoData
    {
        private Conexion conn = new Conexion();
        private MySqlCommand comando;
        public ProductoData()
         {
            conn = new Conexion();
        }

        public bool agregarProducto(Producto _producto)
        {
          string consulta =   "INSERT INTO producto(nombre_producto, precio, stock, estado)VALUE(@nombre_producto, @precio, @stock, @estado)";
            comando = new MySqlCommand(consulta, conn.GetConnection());
            comando.Parameters.Add("@nombre_producto",MySqlDbType.VarChar);
            comando.Parameters["@nombre_producto"].Value = _producto.Nombre_Producto;
            comando.Parameters.Add("@precio", MySqlDbType.Double);
            comando.Parameters["@precio"].Value = _producto.Precio;
            comando.Parameters.Add("@stock", MySqlDbType.Int16);
            comando.Parameters["@stock"].Value = _producto.Stock;
            comando.Parameters.Add("@estado", MySqlDbType.Int16);
            comando.Parameters["@estado"].Value = _producto.Estado;
            try
            {
                int resultado = comando.ExecuteNonQuery();
                conn.setConexion();
            }
            catch (MySqlException error)
            {
                return false;
                throw;
            }
            finally
            {
                if(conn.estadoConexion() == System.Data.ConnectionState.Open)
                {
                    conn.setConexion();
                }
                comando.Dispose();
            }
            return true;

        }

        public Producto buscarProducto()
        {
            throw new NotImplementedException();
        }

        public Producto buscarProductoXId(int _id)
        {
            Producto producto = new Producto();
            string consulta = "SELECT * FROM producto WHERE id_producto= @id_ AND estado = 1;";
            comando = new MySqlCommand(consulta, conn.GetConnection());

            comando.Parameters.Add("@id_",MySqlDbType.Int16);
            comando.Parameters["@id_"].Value = _id;
            try
            {
                MySqlDataReader puntero = comando.ExecuteReader();
                while (puntero.Read())
                {
                   
                    producto.Id_Producto = puntero.GetInt16(0);
                    producto.Nombre_Producto = puntero.GetString(1);
                    producto.Precio = puntero.GetDouble(2);
                    producto.Stock = puntero.GetInt16(3);
                    producto.Estado = puntero.GetBoolean(4);

                }
            }
            catch (Exception)
            {
                throw;
            }
            return (producto);
        }

        public void eliminarProducto(int id_)
        {
            string consulta = "UPDATE producto SET estado = 0 WHERE id_Producto = @id_;";
            comando = new MySqlCommand(consulta, conn.GetConnection());
            comando.Parameters.Add("@id_", MySqlDbType.Int16);
            comando.Parameters["@id_"].Value = id_;
            try
            {
                int resultado = comando.ExecuteNonQuery();
                conn.setConexion();
            }
            catch (MySqlException error)
            {
                throw;
            }
            finally
            {
                if (conn.estadoConexion() == System.Data.ConnectionState.Open)
                {
                    conn.setConexion();
                }
                comando.Dispose();
            }
           
        }

        public List<Producto> listaProducto()
        {
            List<Producto> listaProducto = new List<Producto>();
            string consulta = "SELECT * FROM producto WHERE estado = 1;";
            comando = new MySqlCommand(consulta, conn.GetConnection());
            try
            {
                MySqlDataReader puntero = comando.ExecuteReader();
                while (puntero.Read())
                {
                    Producto _producto = new Producto();
                    _producto.Id_Producto = puntero.GetInt16(0);
                    _producto.Nombre_Producto = puntero.GetString(1);
                    _producto.Precio = puntero.GetDouble(2);
                    _producto.Stock = puntero.GetInt16(3);
                    _producto.Estado = puntero.GetBoolean(4);

                    listaProducto.Add(_producto);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return (listaProducto);
        }

        public void modificarProducto(Producto _producto)
        {

            string consulta = "UPDATE producto SET nombre_producto=@nombre_,precio=@precio_,stock=@stock_  WHERE id_producto =@id_;";
            comando = new MySqlCommand(consulta, conn.GetConnection());
            comando.Parameters.Add("@nombre_", MySqlDbType.VarChar);
            comando.Parameters["@nombre_"].Value = _producto.Nombre_Producto;
            comando.Parameters.Add("@precio_", MySqlDbType.Double);
            comando.Parameters["@precio_"].Value = _producto.Precio;
            comando.Parameters.Add("@stock_", MySqlDbType.Int16);
            comando.Parameters["@stock"].Value = _producto.Stock;
           
            try
            {
                int resultado = comando.ExecuteNonQuery();
                conn.setConexion();
            }
            catch (MySqlException error)
            {
               
                throw;
            }
            finally
            {
                if (conn.estadoConexion() == System.Data.ConnectionState.Open)
                {
                    conn.setConexion();
                }
                comando.Dispose();
            }
            
        }
    }
}
