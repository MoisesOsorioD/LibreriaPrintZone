using Printzone.DAL;
using Printzone.Entidades;
using System;

namespace Printzone.BLL
{
    public class SalidaBLL
    {
        private readonly SalidaDAL _salidaDAL = new SalidaDAL();

        public bool RegistrarSalida(Salida salida)
        {
            if (salida.cantidad <= 0)
            {
                throw new ArgumentException("La cantidad debe ser mayor que cero.");
            }

            if (string.IsNullOrWhiteSpace(salida.motivo))
            {
                throw new ArgumentException("Debe ingresar un motivo.");
            }

            if (salida.id_producto <= 0)
            {
                throw new ArgumentException("Debe seleccionar un producto.");
            }

            if (salida.id_usuario <= 0)
            {
                throw new ArgumentException("Debe existir un usuario válido.");
            }

            return _salidaDAL.RegistrarSalida(salida);
        }



        public List<Salida> ObtenerUltimasSalidas()
        {
            return _salidaDAL.ObtenerUltimasSalidas();
        }



        public List<Salida> ObtenerSalidas()
        {
            return _salidaDAL.ObtenerSalidas();
        }

    }
}