using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Application.DTOs.StudentExamDtos
{
    public class StudentExamResultDto
    {
        public int ExamId { get; set; }
        public string? ExamTitle { get; set; }
        public int TotalScore { get; set; }
        public int CorrectCount { get; set; }
        public int WrongCount { get; set; }
    }

    public class StudentExamSubmitDto
    {
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public List<StudentAnswerDto>? Answers { get; set; }
    }

    public class StudentAnswerDto
    {
        public int QuestionId { get; set; }
        public string? SelectedOption { get; set; }
    }

}
