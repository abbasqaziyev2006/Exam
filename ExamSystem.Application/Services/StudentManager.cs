using AutoMapper;
using ExamSystem.Application.DTOs.Student;
using ExamSystem.Application.Interfaces;
using ExamSystem.Domain.Entities;
using ExamSystem.Domain.Interfaces;

namespace ExamSystem.Application.Services
{
    public class StudentManager : CrudManager<Student, StudentDto, StudentCreateDto, StudentUpdateDto>, IStudentService
    {
        public StudentManager( IMapper mapper) : base(mapper)
        {
        }
    }
}
