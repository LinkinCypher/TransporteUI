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
    public class estudiantesServicios
    {
        readonly IestudiantesRepositorio estudiantesRepositorio;

        public estudiantesServicios()
        {
            estudiantesRepositorio = new estudiantesRepositorio();
        }

        public void InsertarEstudiante(estudiantes nuevo)
        {
            estudiantesRepositorio.Add(nuevo);
        }

        public void ActualizarEstudiante(estudiantes actualiza)
        {
            estudiantesRepositorio.Update(actualiza);
        }

        public IEnumerable<estudiantes> ListarEstudiantes()
        {
            return estudiantesRepositorio.GetAll();
        }

        public IEnumerable<estudiantes> BuscarPorCedula(string cedula)
        {
            return estudiantesRepositorio.GetAll()
                       .Where(e => e.cedula.ToString() == cedula)
                       .ToList();
        }

        public void EliminarEstudiante(int id)
        {
            estudiantesRepositorio.Delete(id);
        }
    }
}
