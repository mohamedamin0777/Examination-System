using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    enum QuestionType
    {
        TrueOrFalse = 1,
        MCQ
    }
    public abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public List<Answer> Answers { get; set; } = new List<Answer>();
        public Answer CorrectAnswer { get; set; }

        public void CreateQuestion()
        {
            Console.WriteLine("Enter question header:");
            Header = Console.ReadLine();

            Console.WriteLine("Enter question body:");
            Body = Console.ReadLine();

            Console.WriteLine("Enter mark for the question:");
            Mark = int.Parse(Console.ReadLine());
        }

        public abstract void CreateAnswers();

        public void CreateRightAnswer()
        {
            Console.WriteLine("Enter the correct answer (answer id):");
            if (int.TryParse(Console.ReadLine(), out int correctAnswerId))
                CorrectAnswer = Answers.Find(answer => answer.AnswerId == correctAnswerId);
            else
                Console.WriteLine("Invalid input for correct answer.");
        }
    }
}
