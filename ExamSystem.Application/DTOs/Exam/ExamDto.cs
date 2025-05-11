using ExamSystem.Application.DTOs.QuestionDtos;

namespace ExamSystem.Application.DTOs.Exam
{
    public class ExamDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public List<QuestionDto>? Questions { get; set; }
    }

    public class ExamCreateDto
    {
        public string? Title { get; set; }
        public List<int>? QuestionIds { get; set; }
    }

    public class ExamUpdateDto
    {
        public string? Title { get; set; }
        public List<int>? QuestionIds { get; set; }
    }
}
