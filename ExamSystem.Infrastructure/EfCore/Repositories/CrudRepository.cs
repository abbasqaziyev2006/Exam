using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Infrastructure.EfCore.Repositories
{
    public class CrudRepository
    {
        public void Add<T>(T entity)
        {
            // Code to add entity to the database
        }
        public T GetById<T>(int id)
        {
            // Code to get entity by ID from the database
            return default(T);
        }
        public IEnumerable<T> GetAll<T>()
        {
            // Code to get all entities from the database
            return Enumerable.Empty<T>();
        }
        public void Update<T>(T entity)
        {
            // Code to update entity in the database
        }
        public void Delete<T>(int id)
        {
            // Code to delete entity by ID from the database
        }

    }
}
