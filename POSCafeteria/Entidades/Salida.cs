using System;
using System.Collections.Generic;
using System.Text;

namespace Printzone.Entidades
{
    public class Salida
    {
        public int id_salida { get; set; }

        public DateTime fecha_salida { get; set; }

        public int cantidad { get; set; }

        public string motivo { get; set; }

        public int id_usuario { get; set; }

        public int id_producto { get; set; }

        public string nombre_producto { get; set; }

        public string nombre_usuario { get; set; }
    }
}
