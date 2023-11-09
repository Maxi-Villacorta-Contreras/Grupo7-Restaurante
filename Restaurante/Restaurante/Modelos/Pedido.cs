using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Modelos
{
    internal class Pedido
    {
        private int id_Pedido { set; get; }
        private int id_mesa { set; get; }
        private string nombre_mesero { set; get; }
        private DateTime fecha_hora { set; get; }
        private Double importe { set; get; }
        private bool cobrada { set; get; }

        public Pedido()
        {
        }

        public Pedido(int id_mesa, string nombre_mesero, DateTime fecha_hora, double importe, bool cobrada)
        {
            this.id_mesa = id_mesa;
            this.nombre_mesero = nombre_mesero;
            this.fecha_hora = fecha_hora;
            this.importe = importe;
            this.cobrada = cobrada;
        }

        public Pedido(int id_Pedido, int id_mesa, string nombre_mesero, DateTime fecha_hora, double importe, bool cobrada)
        {
            this.id_Pedido = id_Pedido;
            this.id_mesa = id_mesa;
            this.nombre_mesero = nombre_mesero;
            this.fecha_hora = fecha_hora;
            this.importe = importe;
            this.cobrada = cobrada;
        }
    }
}
