using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Domain.Entities
{
    public class Exam : Entity
    {
        public string Title { get; set; } = null!;
        public Teacher? Teacher { get; set; }
        public int TeacherId {  get; set; }
        public List<QuestionExam> QuestionExams { get; set; }=new();
    }
}
