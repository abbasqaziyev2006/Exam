using AutoMapper;
using ExamSystem.Application.DTOs.QuestionDtos;
using ExamSystem.Application.Interfaces;
using ExamSystem.Domain.Entities;
using ExamSystem.Domain.Interfaces;

namespace ExamSystem.Application.Services
{
    public class QuestionManager : CrudManager<Question, QuestionDto, QuestionCreateDto, QuestionUpdateDto>, IQuestionService
    {
        public QuestionManager(IMapper mapper) : base( mapper)
        {
        }
    }
}
