using ExamSystem.Domain.Entities;

namespace ExamSystem.Application.Interfaces
{
    public interface IExamService
    {
        Task<Exam> GetByIdAsync(int id);
        Task<IEnumerable<Exam>> GetAllAsync();
        Task AddAsync(Exam exam);
        Task UpdateAsync(Exam exam);
        Task DeleteAsync(int id);
    }



}
