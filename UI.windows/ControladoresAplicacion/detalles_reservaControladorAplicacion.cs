﻿using Aplicacion.Servicios;
using Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.windows.VistaModelo;

namespace UI.windows.ControladoresAplicacion
{
    public class detalles_reservaControladorAplicacion
    {
        private detalles_reservaServicios Detalles_ReservaServicios;
        public detalles_reservaControladorAplicacion()
        {
            Detalles_ReservaServicios = new detalles_reservaServicios();
        }

        public bool InsertarDetalle_Reserva(detalles_reservaVistaModelo nuevoVistaModelo)
        {
            detalles_reserva nuevoET = new detalles_reserva();
            try
            {
                nuevoET.barrio = nuevoVistaModelo.Barrio;
                nuevoET.calles = nuevoVistaModelo.Calles;
                nuevoET.casa = nuevoVistaModelo.Casa;
                nuevoET.referencia = nuevoVistaModelo.Referencia;
                nuevoET.telefono = nuevoVistaModelo.Telefono;
                Detalles_ReservaServicios.InsertarDetalles_Reserva(nuevoET);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString()); 
                return false;
            }
        }

        public bool ActualizarDetalle_Reserva(detalles_reservaVistaModelo actualizarVistaModelo)
        {
            detalles_reserva actualizarET = new detalles_reserva();
            try
            {
                actualizarET.id_detalle_reserva = actualizarET.id_detalle_reserva;
                actualizarET.barrio = actualizarVistaModelo.Barrio;
                actualizarET.calles = actualizarVistaModelo.Calles;
                actualizarET.casa = actualizarVistaModelo.Casa;
                actualizarET.referencia = actualizarVistaModelo.Referencia;
                actualizarET.telefono = actualizarVistaModelo.Telefono;
                Detalles_ReservaServicios.ActualizarDetalles_Reserva(actualizarET);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public List<detalles_reservaVistaModelo> ListarDetalles_Reserva()
        {
            List<detalles_reservaVistaModelo> resultadoVistaModelo = new List<detalles_reservaVistaModelo>();
            var resultadoDB = Detalles_ReservaServicios.ListarDetalles_Reserva();
            try
            {
                foreach (detalles_reserva item in  resultadoDB)
                {
                    resultadoVistaModelo.Add(new detalles_reservaVistaModelo
                    {
                        Id_detalle_reserva = item.id_detalle_reserva,
                        Barrio = item.barrio,
                        Calles = item.calles,
                        Casa = item.casa,
                        Referencia = item.referencia,
                        Telefono = item.telefono,
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
