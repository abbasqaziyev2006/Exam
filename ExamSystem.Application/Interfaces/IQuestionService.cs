using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Application.DTOs.QuestionDtos;
using ExamSystem.Domain.Entities;

namespace ExamSystem.Application.Interfaces
{
    public interface IQuestionService: ICrudService<Question, QuestionDto, QuestionCreateDto, QuestionUpdateDto>
    {
    }
}
