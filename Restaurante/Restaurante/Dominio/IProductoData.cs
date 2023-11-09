using Restaurante.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Dominio
{
    internal interface IProductoData
    {
        bool agregarProducto(Producto _producto);
        void eliminarProducto(int _id);
        void modificarProducto(Producto _producto);
        List<Producto> listaProducto();
        Producto buscarProducto();
        Producto buscarProductoXId(int _id);
    }
}
