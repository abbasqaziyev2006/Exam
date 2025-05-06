using System.Collections.Generic;

namespace ExamSystem.Domain.Interfaces
{
    public interface ICrudRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
