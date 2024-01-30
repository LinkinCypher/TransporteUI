using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.windows.VistaModelo
{
    public class estudiantesVistaModelo
    {
        public int Id_estudiante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Nullable<int> Cedula { get; set; }
        public string Edad { get; set; }
        public string Especialidad { get; set; }
        public string Semestre { get; set; }
        public Nullable<System.DateTime> Fecha_Registro { get; set; }
    }
}
