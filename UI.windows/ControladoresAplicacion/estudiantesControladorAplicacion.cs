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
                nuevoET.nombre = nuevoVistaModelo.Nombre;
                nuevoET.apellido = nuevoVistaModelo.Apellido;
                nuevoET.cedula = nuevoVistaModelo.Cedula;
                nuevoET.edad = nuevoVistaModelo.Edad;
                nuevoET.especialidad = nuevoVistaModelo.Especialidad;
                nuevoET.semestre = nuevoVistaModelo.Semestre;
                nuevoET.fecha_Registro = nuevoVistaModelo.Fecha_Registro;
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
                actualizarET.id_estudiante = actualizarVistaModelo.Id_estudiante;
                actualizarET.nombre = actualizarVistaModelo.Nombre;
                actualizarET.apellido = actualizarVistaModelo.Apellido;
                actualizarET.cedula = actualizarVistaModelo.Cedula;
                actualizarET.edad = actualizarVistaModelo.Edad;
                actualizarET.especialidad = actualizarVistaModelo.Especialidad;
                actualizarET.semestre = actualizarVistaModelo.Semestre;
                actualizarET.fecha_Registro = actualizarVistaModelo.Fecha_Registro;
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
                        Id_estudiante = item.id_estudiante,
                        Nombre = item.nombre,
                        Apellido = item.apellido,
                        Cedula = item.cedula,
                        Edad = item.edad,
                        Especialidad = item.especialidad,
                        Semestre = item.semestre,
                        Fecha_Registro = item.fecha_Registro,
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

        public bool EliminarEstudiante(int id_estudiante)
        {
            try
            {
                EstudiantesServicios.EliminarEstudiante(id_estudiante);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
