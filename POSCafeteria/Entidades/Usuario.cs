using System;
using System.Collections.Generic;
using System.Text;

namespace Printzone.Entidades
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; } = string.Empty;
        public string nombre_completo { get; set; } = string.Empty;
        public string clave { get; set; } = string.Empty;
        public string rol { get; set; } = string.Empty;
        public bool activo { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
