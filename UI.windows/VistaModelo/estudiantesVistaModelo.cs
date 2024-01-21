using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.windows.VistaModelo
{
    public class estudiantesVistaModelo
    {
        public int id_estudiante { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Nullable<int> cedula { get; set; }
        public string edad { get; set; }
        public string especialidad { get; set; }
        public string semestre { get; set; }
        public Nullable<System.DateTime> fecha_Registro { get; set; }
    }
}
