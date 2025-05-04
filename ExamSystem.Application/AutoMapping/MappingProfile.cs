using AutoMapper;
using ExamSystem.Application.DTOs.Exam;
using ExamSystem.Application.DTOs.Question;
using ExamSystem.Application.DTOs.QuestionDtos;
using ExamSystem.Application.DTOs.Student;
using ExamSystem.Application.DTOs.TeacherDtos;
using ExamSystem.Domain.Entities;

namespace ExamSystem.Application.AutoMapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Student
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<StudentCreateDto, Student>().ReverseMap();
            CreateMap<StudentUpdateDto, Student>().ReverseMap();
            CreateMap<StudentRegisterDto, Student>().ReverseMap();
            CreateMap<StudentLoginDto, Student>().ReverseMap();

            // Teacher
            CreateMap<Teacher, TeacherDto>().ReverseMap();
            CreateMap<TeacherCreateDto, Teacher>().ReverseMap();
            CreateMap<TeacherUpdateDto, Teacher>().ReverseMap();

            // Exam
            CreateMap<Exam, ExamDto>().ReverseMap();
            CreateMap<ExamCreateDto, Exam>().ReverseMap();
            CreateMap<ExamUpdateDto, Exam>().ReverseMap();

            // ExamResult
            CreateMap<ExamResultDto, ExamResultDto>().ReverseMap();
            CreateMap<ExamResultCreateDto, ExamResultDto>().ReverseMap();
            CreateMap<ExamResultUpdateDto, ExamResultDto>().ReverseMap();

            // Question
            CreateMap<Question, QuestionDto>().ReverseMap();
            CreateMap<QuestionCreateDto, Question>().ReverseMap();
            CreateMap<QuestionUpdateDto, Question>().ReverseMap();
            CreateMap<Question, QuestionResponseDto>().ReverseMap();

            // QuestionExam (no complex mapping needed)
            CreateMap<QuestionExamDto, Exam>().ReverseMap();
            CreateMap<QuestionExamCreateDto, Exam>().ReverseMap();
            CreateMap<QuestionExamUpdateDto, Exam>().ReverseMap();

            // StudentExam
            CreateMap<StudentExam, StudentExamDto>().ReverseMap();
            CreateMap<StudentExamCreateDto, StudentExam>().ReverseMap();
            CreateMap<StudentExamUpdateDto, StudentExam>().ReverseMap();

            // StudentAnswer
            CreateMap<StudentAnswer, StudentAnswerDto>().ReverseMap();
        }
    }
}
