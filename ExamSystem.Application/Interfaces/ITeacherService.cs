using ExamSystem.Application.DTOs.TeacherDtos;
using ExamSystem.Domain.Entities;

namespace ExamSystem.Application.Interfaces
{
    public interface ITeacherService:ICrudService<Teacher, TeacherDto,TeacherCreateDto, TeacherUpdateDto>
    {
    }
}
