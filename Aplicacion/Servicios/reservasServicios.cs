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
    public class reservasServicios
    {
        readonly IreservaRepositorio reservasRepositorio;

        public reservasServicios()
        {
            reservasRepositorio = new reservasRepositorio();
        }

        public void InsertarReserva(reservas nuevo)
        {
            reservasRepositorio.Add(nuevo);
        }

        public void ActualizarReserva(reservas actualiza)
        {
            reservasRepositorio.Update(actualiza);
        }

        public IEnumerable<reservas> ListarReservas()
        {
            return reservasRepositorio.GetAll();
        }

        public void EliminarReserva(int id)
        {
            reservasRepositorio.Delete(id);
        }
    }
}
