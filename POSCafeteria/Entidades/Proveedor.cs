using System;
using System.Collections.Generic;
using System.Text;

namespace Printzone.Entidades
{
    public class Proveedor
    {
        public int id_proveedor { get; set; }

        public string nombre_empresa { get; set; }

        public string direccion { get; set; }

        public string correo { get; set; }

        public string telefono { get; set; }

        public string nombre_agente { get; set; }

        public string telefono_agente { get; set; }

        public decimal monto_minimo_compra { get; set; }
    }
}
