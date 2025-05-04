using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Application.DTOs.TeacherDtos
{
        public class TeacherDto
        {
            public int Id { get; set; }
            public required string Name { get; set; }
            public required string Username { get; set; }
        }

        public class TeacherCreateDto
        {
            public required string Name { get; set; }
            public required string Username { get; set; }
            public required string Password { get; set; }
        }

        public class TeacherUpdateDto
        {
            public required string Name { get; set; }
            public required string Username { get; set; }
            public required string Password { get; set; }
        }
    }

}
