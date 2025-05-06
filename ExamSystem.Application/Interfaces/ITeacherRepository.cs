using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Application.DTOs.TeacherDtos;

namespace ExamSystem.Application.Interfaces
{
    public interface ITeacherService
    {
        TeacherDto GetById(int id);
        TeacherDto GetByUsername(string username);
        IEnumerable<TeacherDto> GetAll();
        void Add(TeacherDto teacherDto);
        void Update(TeacherDto teacherDto);
        void Delete(int id);
    }
}
