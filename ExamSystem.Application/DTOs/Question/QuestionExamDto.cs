using ExamSystem.Application.DTOs.QuestionDtos;

namespace ExamSystem.Application.DTOs.Question
{
    public class QuestionExamDto
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public string? ExamTitle { get; set; }
        public List<QuestionDto>? Questions { get; set; }
    }

    public class QuestionExamCreateDto
    {
        public int ExamId { get; set; }
        public List<int>? QuestionIds { get; set; }
    }

    public class QuestionExamUpdateDto
    {
        public int Id { get; set; }
        public List<int>? QuestionIds { get; set; }
    }
}

