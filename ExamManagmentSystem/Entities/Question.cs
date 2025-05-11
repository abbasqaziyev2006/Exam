using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExamSystem.Domain.Entities
{
    public class Question : Entity
    {
        public string Text { get; set; }
        public Dictionary<string, string> Options { get; set; }
        public string CorrectKey { get; set; }
    }
}
