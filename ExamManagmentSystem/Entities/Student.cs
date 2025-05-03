using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string UserName { get; set; }= null!;
        public string Password { get; set; } = null!;
        public List<StudentExam> StudentExams { get; set; }=new();
    }
}
