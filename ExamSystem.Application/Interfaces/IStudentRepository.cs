using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Application.DTOs.Student;
using ExamSystem.Domain.Entities;

namespace ExamSystem.Application.Interfaces
{
    public interface IStudentService
    {
        StudentDto GetById(int id);
        IEnumerable<StudentDto> GetAll();
        StudentDto GetByUsername(string username);
        void Add(StudentDto studentDto);
        void Update(StudentDto studentDto);
        void Delete(int id);
    }
}
