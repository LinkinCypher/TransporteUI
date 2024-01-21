using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelo.Abstracciones
{
    public interface IBaseRepositorio <TEntity> where TEntity : class
    {
        void Add(TEntity entity); //insertar
        void Delete(int id); //eliminar
        void Update(TEntity entity); //modificar
        IEnumerable<TEntity> GetAll(); //listar todo
        TEntity GetById(int id); //buscar por id
    }
}
