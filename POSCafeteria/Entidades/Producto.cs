using System;
using System.Collections.Generic;
using System.Text;

namespace Printzone.Entidades
{
    public class Producto
    {
        public int id_producto { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public string marca { get; set; }

        public decimal precio_compra { get; set; }

        public decimal precio_venta { get; set; }

        public string codigo_barras { get; set; }

        public int stock_actual { get; set; }

        public int stock_minimo { get; set; }

        public int id_categoria { get; set; }

        public bool activo { get; set; }


    }
}
