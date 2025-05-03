using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Domain.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }=null!;
        public string Options { get; set; } = null!;
        public string CorrectKey {  get; set; }=null !;
        public List<QuestionExam>? QuestionExams { get; set; }
    }
}
