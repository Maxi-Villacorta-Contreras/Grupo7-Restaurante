using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Modelos
{
    internal class Pedidoproducto
    {
        private int id_pedido_prod { set; get; }
        private int id_pedido { set; get; }
        private int id_producto { set; get; }
        private int cantidad { set; get; }
        public Pedidoproducto()
        {
        }
        public Pedidoproducto(int id_pedido, int id_producto, int cantidad)
        {
            this.id_pedido = id_pedido;
            this.id_producto = id_producto;
            this.cantidad = cantidad;
        }

        public Pedidoproducto(int id_pedido_prod, int id_pedido, int id_producto, int cantidad) : this(id_pedido_prod, id_pedido, id_producto)
        {
            this.cantidad = cantidad;
        }
    }

}
