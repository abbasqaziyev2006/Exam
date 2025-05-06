using System;
using System.Collections.Generic;
    namespace ExamSystem.Application.DTOs.QuestionDtos
    {
        public class QuestionDto
        {
            public int Id { get; set; }
            public required string Text { get; set; }
            public Dictionary<string, string>? Options { get; set; }  // A, B, C...
            public required string CorrectKey { get; set; }
        }

      
        public class QuestionCreateDto
        {
            public required string Text { get; set; }
            public Dictionary<string, string>? Options { get; set; }  // A, B, C...
            public required string CorrectKey { get; set; }
        }

        public class QuestionUpdateDto
        {
            public required string Text { get; set; }
            public Dictionary<string, string>? Options { get; set; }
            public required string CorrectKey { get; set; }
        }

        public class QuestionResponseDto
        {
            public int Id { get; set; }
            public required string Text { get; set; }
            public Dictionary<string, string>? Options { get; set; }
            public required string CorrectKey { get; set; }
        }
    }

