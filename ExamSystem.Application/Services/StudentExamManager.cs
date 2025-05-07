using AutoMapper;
using ExamSystem.Application.DTOs.Student;
using ExamSystem.Application.Interfaces;
using ExamSystem.Domain.Entities;

namespace ExamSystem.Application.Services
{
    public class StudentExamManager : CrudManager<StudentExam, StudentExamDto, StudentExamCreateDto, StudentExamUpdateDto>, IStudentExamService
    {
        
    }
}
