using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Application.DTOs.StudentDtos
{
    public class StudentRegisterDto
    {
        public string? Name { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }

    public class StudentLoginDto
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }

}
