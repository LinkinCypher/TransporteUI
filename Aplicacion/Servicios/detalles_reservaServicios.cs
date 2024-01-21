using Dominio.Modelo.Abstracciones;
using Dominio.Modelo.Entidades;
using Infraestructura.AccesoDatos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Servicios
{
    public class detalles_reservaServicios
    {
        readonly Idetalles_reservaRepositorio detalles_reservaRepositorio;

        public detalles_reservaServicios()
        {
            detalles_reservaRepositorio = new detalles_reservaRepositorio();
        }

        public void InsertarDetalles_Reserva(detalles_reserva nuevo)
        {
            detalles_reservaRepositorio.Add(nuevo);
            ;
        }

        public void ActualizarDetalles_Reserva(detalles_reserva actualiza)
        {
            detalles_reservaRepositorio.Update(actualiza);
        }

        public IEnumerable<detalles_reserva> ListarDetalles_Reserva()
        {
            return detalles_reservaRepositorio.GetAll();
        }

        public void EliminarDetalles_Reserva(int id)
        {
            detalles_reservaRepositorio.Delete(id);
        }
    }
}