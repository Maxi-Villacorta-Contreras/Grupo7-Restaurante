using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Modelos
{
    internal class Mesa
    {
        private int id_Mesa { set; get; }
        private int numero { set; get; }
        private bool estado_Mesa { set; get; }
        private int capacidad { set; get; }

        public Mesa()
        {
        }

        public Mesa(int numero, bool estadoMesa, int capacidad)
        {
            this.numero = numero;
            this.estado_Mesa = estadoMesa;
            this.capacidad = capacidad;
        }

        public Mesa(int idMesa, int numero, bool estadoMesa, int capacidad)
        {
            this.id_Mesa = idMesa;
            this.numero = numero;
            this.estado_Mesa = estadoMesa;
            this.capacidad = capacidad;
        }
    }
}
