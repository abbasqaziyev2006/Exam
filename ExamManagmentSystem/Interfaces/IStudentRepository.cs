using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Domain.Entities;

namespace ExamSystem.Domain.Interfaces
{
    public interface IStudentRepository
    {
        Student GetById(int id);
        IEnumerable<Student> GetAll();
        Student GetByUsername(string username);
        void Add(Student student);
        void Update(Student student);
        void Delete(int id);
    }
}
