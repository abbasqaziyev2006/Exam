using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Domain.Entities;

namespace ExamSystem.Domain.Interfaces
{
    public interface IQuestionRepository
    {
        Question GetById(int id);
        IEnumerable<Question> GetQuestionsByExamId(int examId);
        void Add(Question question);
        void Update(Question question);
        void Delete(int id);
    }
}
