using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Application.DTOs.Exam
{
    public class ExamResultDto
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public string? Result { get; set; }
    }

    public class ExamResultCreateDto
    {
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public string? Result { get; set; }
    }

    public class ExamResultUpdateDto
    {
        public int Id { get; set; }
        public string? Result { get; set; }
    }
}

