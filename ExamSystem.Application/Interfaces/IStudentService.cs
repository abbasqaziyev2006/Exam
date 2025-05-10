using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Application.DTOs.Student;
using ExamSystem.Domain.Entities;

namespace ExamSystem.Application.Interfaces
{
    public interface IStudentService : ICrudService<Student, StudentDto, StudentCreateDto,StudentUpdateDto>
    {
    }
}
