using ExamSystem.Application.DTOs.Student;
using ExamSystem.Domain.Entities;

namespace ExamSystem.Application.Interfaces
{
    public interface IStudentAnswerService
    {
        IEnumerable<StudentAnswerDto> GetAnswersByExamIdAndStudentId(int examId, int studentId);
        void Add(StudentAnswerDto answerDto);
    }

}
