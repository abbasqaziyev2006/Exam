using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Domain.Entities;

namespace ExamSystem.Domain.Interfaces
{
    public interface ITeacherRepository
    {
        Teacher GetById(int id);
        IEnumerable<Teacher> GetAll();
        Teacher GetByUsername(string username);
        void Add(Teacher teacher);
        void Update(Teacher teacher);
        void Delete(int id);

    }
}
