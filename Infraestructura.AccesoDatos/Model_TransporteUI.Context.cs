﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infraestructura.AccesoDatos
{
    using Dominio.Modelo.Entidades;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class transporteUI_DBEntities : DbContext
    {
        public transporteUI_DBEntities()
            : base("name=transporteUI_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<detalles_reserva> detalles_reserva { get; set; }
        public virtual DbSet<estudiantes> estudiantes { get; set; }
        public virtual DbSet<reservas> reservas { get; set; }
    }
}
