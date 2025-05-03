using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Application.DTOs.QuestionDtos
{
    public class QuestionCreateDto
    {
        public string? Text { get; set; }
        public Dictionary<string, string>? Options { get; set; }  // A, B, C...
        public string? CorrectKey { get; set; }
    }


    public class QuestionResponseDto
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public Dictionary<string, string>? Options { get; set; }
        public string? CorrectKey { get; set; }
    }

}
