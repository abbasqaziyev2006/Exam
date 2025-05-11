using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ExamSystem.Domain.Entities;

namespace SimpleExamSystem
{
    class Program
    {
        static List<Question> questions = new List<Question>();

        static void Main()
        {

            if (File.Exists("questions.json"))
            {
                try
                {
                    string json = File.ReadAllText("questions.json");
                    questions = JsonSerializer.Deserialize<List<Question>>(json) ?? new List<Question>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error reading questions file: " + ex.Message);

                    LoadDefaultQuestions();
                }
            }
            else
            {
                LoadDefaultQuestions();
            }

            Console.Write("Are you a Student or Teacher? (S/T): ");
            string role = Console.ReadLine().ToUpper();

            if (role == "T")
            {
                TeacherMenu();
            }
            else if (role == "S")
            {
                StudentMenu();
            }
            else
            {
                Console.WriteLine("Invalid role.");
            }
        }

        static void LoadDefaultQuestions()
        {
            questions = new List<Question>
            {
                new Question { Id = 1, Text = "Capital of Azerbaijan?", Options = new Dictionary<string, string> { { "A", "Baku" }, { "B", "Ganja" }, { "C", "Sumgayit" } }, CorrectKey = "A" },
                new Question { Id = 2, Text = "Highest mountain in Azerbaijan?", Options = new Dictionary<string, string> { { "A", "Bazarduzu" }, { "B", "Shahdag" }, { "C", "Tufandag" } }, CorrectKey = "A" },
                new Question { Id = 3, Text = "Chemical symbol of Oxygen?", Options = new Dictionary<string, string> { { "A", "Sulfur" }, { "B", "Oxygen" }, { "C", "Nitrogen" } }, CorrectKey = "B" },
                new Question { Id = 4, Text = "Longest river in the world?", Options = new Dictionary<string, string> { { "A", "Amazon" }, { "B", "Nile" }, { "C", "Yangtze" } }, CorrectKey = "B" },
                new Question { Id = 5, Text = "Country with most pyramids?", Options = new Dictionary<string, string> { { "A", "Egypt" }, { "B", "Sudan" }, { "C", "Mexico" } }, CorrectKey = "B" }
            };

            SaveQuestionsToFile();
        }

        static void SaveQuestionsToFile()
        {
            string updatedJson = JsonSerializer.Serialize(questions);
            File.WriteAllText("questions.json", updatedJson);
        }

        static void TeacherMenu()
        {
            Console.Write("Password: ");
            if (Console.ReadLine() == "teacher123")
            {
                bool continueMenu = true;
                while (continueMenu)
                {
                    Console.WriteLine("\nTeacher Menu:");
                    Console.WriteLine("1. Add Question");
                    Console.WriteLine("2. Remove Question");
                    Console.WriteLine("3. Logout");
                    Console.Write("Select an option: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            AddQuestion();
                            break;
                        case "2":
                            RemoveQuestion();
                            break;
                        case "3":
                            Console.WriteLine("Logged out successfully.");
                            continueMenu = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Wrong password.");
            }
        }

        static void AddQuestion()
        {
            Console.WriteLine("\nEnter new question details:");

            Console.Write("Question text: ");
            string text = Console.ReadLine();

            Dictionary<string, string> opts = new Dictionary<string, string>();
            while (true)
            {
                Console.Write("Add option (e.g. A=Answer), or press Enter to stop: ");
                string line = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(line)) break;

                var parts = line.Split('=');
                if (parts.Length == 2)
                    opts[parts[0].Trim().ToUpper()] = parts[1].Trim();
            }

            Console.Write("Correct option key: ");
            string correct = Console.ReadLine().Trim().ToUpper();

            int newId = questions.Count + 1;
            questions.Add(new Question { Id = newId, Text = text, Options = opts, CorrectKey = correct });

            SaveQuestionsToFile();
            Console.WriteLine("Question added successfully.");
        }

        static void RemoveQuestion()
        {
            Console.WriteLine("\nSelect a question to remove:");

            // Soruları listele
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {questions[i].Text}");
            }

            Console.Write("Enter question number to remove (or press Enter to cancel): ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input)) return;

            if (int.TryParse(input, out int questionNumber) && questionNumber >= 1 && questionNumber <= questions.Count)
            {
                questions.RemoveAt(questionNumber - 1);
                SaveQuestionsToFile();
                Console.WriteLine("Question removed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid question number.");
            }
        }

        static void StudentMenu()
        {
            Console.Write("Password: ");
            if (Console.ReadLine() == "student123")
            {
                int correctCount = 0;
                Console.WriteLine("\nExam Start:");
                foreach (var q in questions)
                {
                    Console.WriteLine("\n" + q.Text);
                    foreach (var opt in q.Options)
                        Console.WriteLine($"{opt.Key}) {opt.Value}");

                    Console.Write("Answer: ");
                    string answer = Console.ReadLine().Trim().ToUpper();

                    if (answer == q.CorrectKey)
                    {
                        Console.WriteLine("Correct!");
                        correctCount++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong. Correct answer was {q.CorrectKey}");
                    }
                }

                double score = (double)correctCount / questions.Count * 100;
                Console.WriteLine($"\nScore: {score:F2}%");
            }
            else
            {
                Console.WriteLine("Wrong password.");
            }
        }
    }
}
