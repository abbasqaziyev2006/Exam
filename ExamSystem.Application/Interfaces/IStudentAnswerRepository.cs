using ExamSystem.Domain.Entities;

namespace ExamSystem.Application.Interfaces
{
    public interface IStudentAnswerRepository
    {
        Task<StudentAnswer> GetByIdAsync(int id);
        Task<IEnumerable<StudentAnswer>> GetByStudentExamIdAsync(int studentExamId);
        Task AddAsync(StudentAnswer studentAnswer);
    }

}
