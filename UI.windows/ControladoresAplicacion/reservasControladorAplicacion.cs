using Aplicacion.Servicios;
using Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.windows.VistaModelo;

namespace UI.windows.ControladoresAplicacion
{
    public class reservasControladorAplicacion
    {
        private reservasServicios ReservasServicios;
        public reservasControladorAplicacion() 
        { 
            ReservasServicios = new reservasServicios();
        }

        public bool InsertarReserva(reservasVistaModelo nuevoVistaModelo)
        {
            reservas nuevoET = new reservas();
            try
            {
                nuevoET.sur = nuevoVistaModelo.Sur;
                nuevoET.centro = nuevoVistaModelo.Centro;
                nuevoET.norte = nuevoVistaModelo.Norte;
                ReservasServicios.InsertarReserva(nuevoET);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarReserva(reservasVistaModelo actualizarVistaModelo)
        {
            reservas actualizarET = new reservas();
            try
            {
                actualizarET.id_reserva = actualizarVistaModelo.Id_reserva;
                actualizarET.sur = actualizarVistaModelo.Sur;
                actualizarET.centro = actualizarVistaModelo.Centro;
                actualizarET.norte = actualizarVistaModelo.Norte;
                ReservasServicios.ActualizarReserva(actualizarET);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public List<reservasVistaModelo> ListarReservas()
        {
            List<reservasVistaModelo> resultadoVistaModelo = new List<reservasVistaModelo>();
            var resultadoDB = ReservasServicios.ListarReservas();
            try
            {
                foreach (reservas item in resultadoDB)
                {
                    resultadoVistaModelo.Add(new reservasVistaModelo()
                    {
                        Id_reserva = item.id_reserva,
                        Sur = item.sur,
                        Centro = item.centro,
                        Norte = item.norte,
                    });
                }
                return resultadoVistaModelo;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
