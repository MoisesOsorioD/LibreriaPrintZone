using Printzone.DAL;
using Printzone.Entidades;
using System;

namespace Printzone.BLL
{
    public class EntradaBLL
    {
        private readonly EntradaDAL _entradaDAL = new EntradaDAL();

        public bool RegistrarEntrada(Entrada entrada)
        {
            if (entrada.cantidad <= 0)
            {
                throw new ArgumentException("La cantidad debe ser mayor que cero.");
            }

            if (entrada.costo_lote <= 0)
            {
                throw new ArgumentException("El costo del lote debe ser mayor que cero.");
            }

            if (entrada.id_producto <= 0)
            {
                throw new ArgumentException("Debe seleccionar un producto.");
            }

            if (entrada.id_proveedor <= 0)
            {
                throw new ArgumentException("Debe seleccionar un proveedor.");
            }

            return _entradaDAL.RegistrarEntrada(entrada);
        }



        public List<Entrada> ObtenerUltimasEntradas()
        {
            return _entradaDAL.ObtenerUltimasEntradas();
        }



        public List<Entrada> ObtenerEntradas()
        {
            EntradaDAL entradaDAL = new EntradaDAL();

            return entradaDAL.ObtenerEntradas();
        }
    }
}