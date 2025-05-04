using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Application.DTOs.Student
{
    public class StudentExamDto
    {
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public string? Result { get; set; }
        public int CorrectCount { get; set; }
        public int WrongCount { get; set; }
        public int TotalQuestions { get; set; }
    }

    public class StudentExamCreateDto
    {
        public int StudentId { get; set; }
        public int ExamId { get; set; }
    }

    public class StudentExamUpdateDto
    {
        public string? Result { get; set; }
        public int CorrectCount { get; set; }
        public int WrongCount { get; set; }
    }
}

