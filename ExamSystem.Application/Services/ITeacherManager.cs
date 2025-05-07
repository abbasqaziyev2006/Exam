using AutoMapper;
using ExamSystem.Application.DTOs.TeacherDtos;
using ExamSystem.Application.Interfaces;
using ExamSystem.Domain.Entities;
using ExamSystem.Domain.Interfaces;

namespace ExamSystem.Application.Services
{
    public class TeacherManager : CrudManager<Teacher, TeacherDto, TeacherCreateDto, TeacherUpdateDto>, ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherManager(ITeacherRepository teacherRepository, IMapper mapper) : base(teacherRepository, mapper)
        {
            _teacherRepository = teacherRepository;
        }

        public TeacherDto GetByUsername(string username)
        {
            var teacher = _teacherRepository.GetByUsername(username);
            return Mapper.Map<TeacherDto>(teacher);
        }
    }
}
