using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Examination_System
{
    enum ExamType
    {
        Final = 1,
        Practical
    }
    public abstract class Exam
    {
        public TimeSpan TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public List<Question> Questions { get; set; }

        public int GainedMark = 0;
        public int TotalMark = 0;
        public int enteredAnswerID;

        public abstract void CheckAnswers();
        public void ShowExamForm()
        {
            foreach (var question in Questions)
            {
                TotalMark += question.Mark;
                Console.WriteLine($"Question Type: {question.Header}");
                Console.WriteLine($"Mark: {question.Mark}");
                Console.WriteLine($"Question:\n {question.Body}");
                Console.WriteLine("Answers:");
                foreach (var answer in question.Answers)
                {
                    Console.WriteLine($"{answer.AnswerId}. {answer.AnswerText}");
                }
                Console.WriteLine();
                Console.WriteLine("Enter the correct answer (answer id): ");
                enteredAnswerID = int.Parse(Console.ReadLine());
                Console.WriteLine("===============================================");
            }
        }
        public void PrintResult()
        {
            Console.WriteLine($"Your total marks: {GainedMark} out of {TotalMark}");
        }
    }
}
