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
            return Mapper.Map<QuestionDto>(question);
        }

        public IEnumerable<QuestionDto> GetByExamId(int examId)
        {
            var questions = _questionRepository.GetByExamId(examId);
            return Mapper.Map<IEnumerable<QuestionDto>>(questions);
        }

        public IEnumerable<QuestionDto> GetQuestionsByExamId(int examId)
        {
            throw new NotImplementedException();
        }

        public void Add(QuestionDto questionDto)
        {
            throw new NotImplementedException();
        }

        public void Update(QuestionDto questionDto)
        {
            throw new NotImplementedException();
        }

        void IQuestionService.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
