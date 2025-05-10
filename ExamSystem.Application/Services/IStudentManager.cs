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

        public void Add(StudentDto studentDto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StudentDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public StudentDto GetByUsername(string username)
        {
            var student = _studentRepository.GetByUsername(username);
            return Mapper.Map<StudentDto>(student);
        }

        public void Update(StudentDto studentDto)
        {
            throw new NotImplementedException();
        }

        void IStudentService.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
