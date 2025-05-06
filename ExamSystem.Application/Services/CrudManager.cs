using AutoMapper;
using ExamSystem.Domain.Interfaces;
using System.Collections.Generic;

namespace ExamSystem.Application.Services
{
    public class CrudManager<TEntity, TDto, TCreateDto, TUpdateDto>
        where TEntity : class
    {
        protected readonly ICrudRepository<TEntity> _repository;
        protected readonly IMapper _mapper;
        private IQuestionRepository questionRepository;

        public ITeacherRepository TeacherRepository { get; }
        public IMapper Mapper { get; }
        public IStudentRepository StudentRepository { get; }

        public CrudManager(ICrudRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public CrudManager(ITeacherRepository teacherRepository, IMapper mapper)
        {
            TeacherRepository = teacherRepository;
            Mapper = mapper;
        }

        public CrudManager(IStudentRepository studentRepository, IMapper mapper)
        {
            StudentRepository = studentRepository;
            Mapper = mapper;
        }

        public CrudManager(IQuestionRepository questionRepository, IMapper mapper)
        {
            this.questionRepository = questionRepository;
            Mapper = mapper;
        }

        public TDto GetById(int id)
        {
            var entity = _repository.GetById(id);
            return _mapper.Map<TDto>(entity);
        }


        public IEnumerable<TDto> GetAll()
        {
            var entities = _repository.GetAll();
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }


        public void Add(TCreateDto createDto)
        {
            var entity=_mapper.Map<TEntity>(createDto);
            _repository.Add(entity);
        }

        public void Update(TUpdateDto updateDto)
        {
            var entity = _mapper.Map<TEntity>(updateDto);
            _repository.Update(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
    
}
