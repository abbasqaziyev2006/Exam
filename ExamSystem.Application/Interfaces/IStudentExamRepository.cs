using ExamSystem.Application.DTOs.Student;
using ExamSystem.Domain.Entities;

namespace ExamSystem.Application.Interfaces
{
    public interface IStudentExamService
    {
        StudentExamDto GetById(int id);
        IEnumerable<StudentExamDto> GetExamsByStudentId(int studentId);
        void Add(StudentExamDto studentExamDto);
    }

}
