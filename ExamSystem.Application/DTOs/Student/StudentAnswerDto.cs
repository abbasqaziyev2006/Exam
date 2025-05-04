using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Application.DTOs.Student
{
    public class StudentAnswerDto
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public int QuestionId { get; set; }
        public string? SelectedKey { get; set; }
    }

    public class StudentAnswerCreateDto
    {
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public int QuestionId { get; set; }
        public string? SelectedKey { get; set; }
    }

    public class StudentAnswerUpdateDto
    {
        public int Id { get; set; }
        public string? SelectedKey { get; set; }
    }
}
