using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExamSystem.Domain.Entities
{
    public class Question : Entity
    {
        public string Text { get; set; } = null!;
        public string Options { get; set; } = null!;
        public string CorrectKey { get; set; } = null!;
        public List<QuestionExam>? QuestionExams { get; set; }
    }
}
