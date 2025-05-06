using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Application.DTOs.QuestionDtos;
using ExamSystem.Domain.Entities;

namespace ExamSystem.Application.Interfaces
{
    public interface IQuestionService
    {
        QuestionDto GetById(int id);
        IEnumerable<QuestionDto> GetQuestionsByExamId(int examId);
        void Add(QuestionDto questionDto);
        void Update(QuestionDto questionDto);
        void Delete(int id);
    }
}
