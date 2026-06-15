using System;
using System.Collections.Generic;
using System.Text;

namespace Printzone.Entidades
{
    public class Entrada
    {
        public int id_entrada { get; set; }

        public DateTime fecha_entrada { get; set; }

        public int cantidad { get; set; }

        public decimal costo_lote { get; set; }

        public int id_proveedor { get; set; }

        public int id_producto { get; set; }


        public string nombre_producto { get; set; }

        public string nombre_proveedor { get; set; }
    }
}
