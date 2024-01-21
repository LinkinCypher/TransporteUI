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
                nuevoET.sur = nuevoVistaModelo.sur;
                nuevoET.centro = nuevoVistaModelo.centro;
                nuevoET.norte = nuevoVistaModelo.norte;
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
                actualizarET.id_reserva = actualizarVistaModelo.id_reserva;
                actualizarET.sur = actualizarVistaModelo.sur;
                actualizarET.centro = actualizarVistaModelo.centro;
                actualizarET.norte = actualizarVistaModelo.norte;
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
                        id_reserva = item.id_reserva,
                        sur = item.sur,
                        centro = item.centro,
                        norte = item.norte,
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
