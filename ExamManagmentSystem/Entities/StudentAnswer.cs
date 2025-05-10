using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Domain.Entities
{
    public class StudentAnswer : Entity
    {
        public int QuestionId { get; set; }
        public Question Question { get; set; } = new();
        public StudentExam StudentExam { get; set; } = new();
        public string? SelectedOption { get; set; }
    }
}
