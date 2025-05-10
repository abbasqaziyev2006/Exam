using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Domain.Entities
{
    public class StudentExam : Entity
    {
        public int StudentId {  get; set; }
        public Student Student { get; set; } = null!;
        public int ExamId {  get; set; }
        public Exam Exam { get; set; } = null!;
        public int Score {  get; set; }
        public List<StudentAnswer> Answers { get; set; }= new();
    }
}
