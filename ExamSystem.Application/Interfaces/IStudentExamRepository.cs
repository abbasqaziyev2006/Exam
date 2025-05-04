using ExamSystem.Domain.Entities;

namespace ExamSystem.Application.Interfaces
{
    public interface IStudentExamRepository
    {
        Task<StudentExam> GetByIdAsync(int id);
        Task<IEnumerable<StudentExam>> GetByStudentIdAsync(int studentId);
        Task AddAsync(StudentExam studentExam);
        Task UpdateAsync(StudentExam studentExam);
    }

}
