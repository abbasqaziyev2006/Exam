using AutoMapper;
using ExamSystem.Application.DTOs.Student;
using ExamSystem.Application.Interfaces;
using ExamSystem.Domain.Entities;

namespace ExamSystem.Application.Services
{
    public class StudentExamManager : CrudManager<StudentExam, StudentExamDto, StudentExamCreateDto, StudentExamUpdateDto>, IStudentExamService
    {
        private readonly IStudentExamRepository _studentExamRepository;

        public StudentExamManager(IStudentExamRepository studentExamRepository, IMapper mapper) : base(studentExamRepository, mapper)
        {
            _studentExamRepository = studentExamRepository;
        }

        public StudentExamDto GetByStudentId(int studentId)
        {
            var studentExam = _studentExamRepository.GetByStudentId(studentId);
            return _mapper.Map<StudentExamDto>(studentExam);  
        }

 
        public StudentExamDto GetByExamId(int examId)
        {
            var studentExam = _studentExamRepository.GetByExamId(examId);
            return _mapper.Map<StudentExamDto>(studentExam);  
        }
    }
}
