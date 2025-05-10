using AutoMapper;
using ExamSystem.Application.DTOs.TeacherDtos;
using ExamSystem.Application.Interfaces;
using ExamSystem.Domain.Entities;
using ExamSystem.Domain.Interfaces;

namespace ExamSystem.Application.Services
{
    public class TeacherManager : CrudManager<Teacher, TeacherDto, TeacherCreateDto, TeacherUpdateDto>, ITeacherService
    {
        public TeacherManager(IMapper mapper) : base( mapper)
        {
        }
    }
}
