using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Domain.Entities;

namespace ExamSystem.Application.Interfaces
{
    public interface IQuestionRepository
    {
        Task<Question> GetByIdAsync(int id);
        Task<IEnumerable<Question>> GetAllAsync();
        Task AddAsync(Question question);
        Task UpdateAsync(Question question);
        Task DeleteAsync(int id);
    }

}
