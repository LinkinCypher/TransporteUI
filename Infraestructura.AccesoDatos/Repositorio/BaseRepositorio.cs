using Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Dominio.Modelo;

namespace Infraestructura.AccesoDatos.Repositorio
{
    public class BaseRepositorio<TEntity> : IDisposable, IBaseRepositorio<TEntity> where TEntity : class
    {


        public void Add(TEntity entity)
        {
            try
            {
                using (var context = new transporteUI_DBEntities()) //crear la conexion a la DB
                {
                    context.Set<TEntity>().Add(entity); //insertar
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error: No se pudo insertar el registro", ex);
            }
        }


        public void Delete(int id)
        {
            try
            {
                using (var context = new transporteUI_DBEntities()) //crear la conexion a la DB
                {
                    var entity = context.Set<TEntity>().Find(id); //buscar registro si existe
                    context.Set<TEntity>().Remove(entity); //eliminar
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error: No se pudo eliminar el registro", ex);
            }
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                using (var context = new transporteUI_DBEntities()) //crear la conexion a la DB
                {
                    return context.Set<TEntity>().ToList(); //listar todo
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error: No se pudo listar todos los registros", ex);
            }
        }


        public TEntity GetById(int id)
        {
            try
            {
                using (var context = new transporteUI_DBEntities()) //crear la conexion a la DB
                {
                    return context.Set<TEntity>().Find(id); //listar un registro
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error: No se pudo listar un registro", ex);
            }
        }


        public void Update(TEntity entity)
        {
            try
            {
                using (var context = new transporteUI_DBEntities()) //crear la conexion a la DB
                {
                    context.Entry(entity).State = EntityState.Modified; //validar dato modificado
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error: No se pudo actualizar el registro", ex);
            }
        }
    }
}
