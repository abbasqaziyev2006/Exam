using ExamSystem.Application.DTOs.Exam;
using ExamSystem.Domain.Entities;

namespace ExamSystem.Application.Interfaces
{
    public interface IExamService
    {
        ExamDto GetById(int id);
        IEnumerable<ExamDto> GetAll();
        IEnumerable<ExamDto> GetExamsByTeacherId(int teacherId);
        void Add(ExamDto examDto);
        void Update(ExamDto examDto);
        void Delete(int id);
    }
}
