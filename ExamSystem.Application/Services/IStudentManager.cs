using AutoMapper;
using ExamSystem.Application.DTOs.Student;
using ExamSystem.Application.Interfaces;
using ExamSystem.Domain.Entities;
using ExamSystem.Domain.Interfaces;

namespace ExamSystem.Application.Services
{
    public class StudentManager : CrudManager<Student, StudentDto, StudentCreateDto, StudentUpdateDto>, IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentManager(IStudentRepository studentRepository, IMapper mapper) : base(studentRepository, mapper)
        {
            _studentRepository = studentRepository;
        }

        public StudentDto GetByUsername(string username)
        {
            var student = _studentRepository.GetByUsername(username);
            return _mapper.Map<StudentDto>(student);
        }

    }
}
