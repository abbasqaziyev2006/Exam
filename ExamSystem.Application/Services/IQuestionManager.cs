using AutoMapper;
using ExamSystem.Application.DTOs.QuestionDtos;
using ExamSystem.Application.Interfaces;
using ExamSystem.Domain.Entities;
using ExamSystem.Domain.Interfaces;

namespace ExamSystem.Application.Services
{
    public class QuestionManager : CrudManager<Question, QuestionDto, QuestionCreateDto, QuestionUpdateDto>, IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionManager(IQuestionRepository questionRepository, IMapper mapper) : base(questionRepository, mapper)
        {
            _questionRepository = questionRepository;
        }

        public QuestionDto GetById(int id)
        {
            var question = _questionRepository.GetById(id);
            return _mapper.Map<QuestionDto>(question);
        }

        public IEnumerable<QuestionDto> GetByExamId(int examId)
        {
            var questions = _questionRepository.GetByExamId(examId);
            return _mapper.Map<IEnumerable<QuestionDto>>(questions);
        }
    }
}
