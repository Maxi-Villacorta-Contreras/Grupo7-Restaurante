using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Modelos
{
    internal class Producto
    {
        private int id_Producto;
        private string nombre_Producto;
        private double precio;
        private int stock;
        private bool estado;

        public Producto()
        {
        }

        public Producto(string nombreProducto, double precio, int stock, bool estado)
        {
            this.Nombre_Producto = nombreProducto;
            this.Precio = precio;
            this.Stock = stock;
            this.Estado = estado;
        }

        public Producto(int idProducto, string nombreProducto, double precio, int stock, bool estado)
        {
            this.Id_Producto = idProducto;
            this.Nombre_Producto = nombreProducto;
            this.Precio = precio;
            this.Stock = stock;
            this.Estado = estado;
        }

        public int Id_Producto { get => id_Producto; set => id_Producto = value; }
        public string Nombre_Producto { get => nombre_Producto; set => nombre_Producto = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}
