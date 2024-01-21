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
    public class estudiantesControladorAplicacion
    {
        private estudiantesServicios EstudiantesServicios;
        public estudiantesControladorAplicacion()
        {
            EstudiantesServicios = new estudiantesServicios();
        }

        public bool InsertarEstudiante(estudiantesVistaModelo nuevoVistaModelo)
        {
            estudiantes nuevoET = new estudiantes();
            try
            {
                nuevoET.nombre = nuevoVistaModelo.nombre;
                nuevoET.apellido = nuevoVistaModelo.apellido;
                nuevoET.cedula = nuevoVistaModelo.cedula;
                nuevoET.edad = nuevoVistaModelo.edad;
                nuevoET.especialidad = nuevoVistaModelo.especialidad;
                nuevoVistaModelo.semestre = nuevoVistaModelo.semestre;
                EstudiantesServicios.InsertarEstudiante(nuevoET);
                return true;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarEstudiante(estudiantesVistaModelo actualizarVistaModelo)
        {
            estudiantes actualizarET = new estudiantes();
            try
            {
                actualizarET.id_estudiante = actualizarVistaModelo.id_estudiante;
                actualizarET.nombre = actualizarVistaModelo.nombre;
                actualizarET.apellido = actualizarVistaModelo.apellido;
                actualizarET.cedula = actualizarVistaModelo.cedula;
                actualizarET.edad = actualizarVistaModelo.edad;
                actualizarET.especialidad = actualizarVistaModelo.especialidad;
                actualizarET.semestre = actualizarVistaModelo.semestre;
                EstudiantesServicios.ActualizarEstudiante(actualizarET);
                return true;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                return false;
            }
        }

        public List<estudiantesVistaModelo> ListarEstudiantes()
        {
            List<estudiantesVistaModelo> resultadoVistaModelo = new List<estudiantesVistaModelo> ();
            var resultadoDB = EstudiantesServicios.ListarEstudiantes();
            try
            {
                foreach (estudiantes item in resultadoDB)
                {
                    resultadoVistaModelo.Add(new estudiantesVistaModelo
                    {
                        id_estudiante = item.id_estudiante,
                        nombre = item.nombre,
                        apellido = item.apellido,
                        cedula = item.cedula,
                        edad = item.edad,
                        especialidad = item.especialidad,
                        semestre = item.semestre,
                    });
                }
                return resultadoVistaModelo;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
