using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Application.DTOs.Student
{
    public class StudentDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Username { get; set; }
    }

    public class StudentCreateDto
    {
        public required string Name { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
    }

    public class StudentUpdateDto
    {
        public required string Name { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
    }

    public class StudentRegisterDto
    {
        public required string Name { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
    }

    public class StudentLoginDto
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
}

