using Restaurante.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurante.Modelos;

namespace Restaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductoData datos= new ProductoData();
            Producto producto = new Producto();

            producto.Nombre_Producto = "Pizza";
            producto.Precio = 2000;
            producto.Stock = 10;
            producto.Estado = true;


            //datos.agregarProducto(producto);
            datos.eliminarProducto(6);
        }
    }
}
