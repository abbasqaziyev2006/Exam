using System.Text.Json;

namespace ExamSystem.Application.DTOs.QuestionDtos
{
    public class QuestionDto
    {
        public int Id { get; set; }
        public required string Text { get; set; }
        public required string Options { get; set; }  
        public required string CorrectKey { get; set; }

        public Dictionary<string, string> GetOptions()
        {
            return string.IsNullOrEmpty(Options) ?
                new Dictionary<string, string>() :
                JsonSerializer.Deserialize<Dictionary<string, string>>(Options)!;
        }
    }

    public class QuestionCreateDto
    {
        public required string Text { get; set; }
        public required string Options { get; set; } 
        public required string CorrectKey { get; set; }
    }

    public class QuestionUpdateDto
    {
        public required string Text { get; set; }
        public required string Options { get; set; }  
        public required string CorrectKey { get; set; }
    }

    public class QuestionResponseDto
    {
        public int Id { get; set; }
        public required string Text { get; set; }
        public required string Options { get; set; }  // Options JSON formatında saxlanır
        public required string CorrectKey { get; set; }
    }
}
