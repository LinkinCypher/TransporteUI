//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dominio.Modelo.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class detalles_reserva
    {
        public int id_detalle_reserva { get; set; }
        public string barrio { get; set; }
        public string calles { get; set; }
        public string casa { get; set; }
        public string referencia { get; set; }
        public string telefono { get; set; }
        public Nullable<int> id_reserva { get; set; }
        public Nullable<int> id_estudiante { get; set; }
    
        public virtual estudiantes estudiantes { get; set; }
        public virtual reservas reservas { get; set; }
    }
}
