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
        private readonly IStudentExamRepository _studentExamRepository;

        public StudentExamManager(IStudentExamRepository studentExamRepository, IMapper mapper) : base(studentExamRepository, mapper)
        {
            _studentExamRepository = studentExamRepository;
        }

        public StudentExamDto GetById(int id)
        {
            var studentExam = _studentExamRepository.GetById(id);
            return Mapper.Map<StudentExamDto>(studentExam);
        }

        public IEnumerable<StudentExamDto> GetByStudentId(int studentId)
        {
            var studentExams = _studentExamRepository.GetByStudentId(studentId);
            return Mapper.Map<IEnumerable<StudentExamDto>>(studentExams);
        }

        public IEnumerable<StudentExamDto> GetByExamId(int examId)
        {
            var studentExams = _studentExamRepository.GetByExamId(examId);
            return Mapper.Map<IEnumerable<StudentExamDto>>(studentExams);
        }

        public void Add(StudentExamDto studentExamDto)
        {
            throw new NotImplementedException();
        }

        public void Update(StudentExamDto studentExamDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
