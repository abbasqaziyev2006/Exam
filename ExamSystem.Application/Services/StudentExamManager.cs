using AutoMapper;
using ExamSystem.Application.DTOs.Student;
using ExamSystem.Application.Interfaces;
using ExamSystem.Domain.Entities;
using ExamSystem.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace ExamSystem.Application.Services
{
    public class StudentExamManager : CrudManager<StudentExam, StudentExamDto, StudentExamCreateDto, StudentExamUpdateDto>, IStudentExamService
    {
        public StudentExamManager(IMapper mapper) : base(mapper)
        {
        }
    }
}
