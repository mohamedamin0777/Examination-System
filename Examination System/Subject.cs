using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class Subject 
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam ExamOfSubject { get; set; }

        ExamType examType { get; set; }
        QuestionType questionType { get; set; }

        public void CreateExam()
        {
            Console.WriteLine("Enter exam type (1 for Final/2 for Practical):");
            examType = (ExamType)int.Parse(Console.ReadLine());

            if (examType == ExamType.Final)
                ExamOfSubject = new FinalExam();
            else if (examType == ExamType.Practical)
                ExamOfSubject = new PracticalExam();
            else
            {
                Console.WriteLine("Invalid exam type.");
                return;
            }

            Console.WriteLine("enter the time of exam in minutes: ");
            ExamOfSubject.TimeOfExam = TimeSpan.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of questions:");
            if (int.TryParse(Console.ReadLine(), out int numberOfQuestions))
            {
                ExamOfSubject.NumberOfQuestions = numberOfQuestions;

                List<Question> questions = new List<Question>();

                for (int i = 0; i < numberOfQuestions; i++)
                {
                    Console.Clear();
                    Question question;
                    Console.WriteLine($"Question {i + 1}:");
                    if (ExamOfSubject is FinalExam finalExam)
                    {
                        Console.WriteLine("Enter question type (1 for TrueFalse/2 for MCQ):");
                        questionType = (QuestionType)int.Parse(Console.ReadLine());
                        if (questionType == QuestionType.TrueOrFalse)
                        {
                            question = new TrueFalseQuestion();
                            question.CreateQuestion();
                            question.CreateAnswers();
                            question.CreateRightAnswer();
                            questions.Add(question);
                        }
                        else if (questionType == QuestionType.MCQ)
                        {
                            question = new MCQQuestion();
                            question.CreateQuestion();
                            question.CreateAnswers();
                            question.CreateRightAnswer();
                            questions.Add(question);
                        }
                        finalExam.Questions = questions;
                    }
                    else if (ExamOfSubject is PracticalExam practicalExam)
                    {
                        question = new MCQQuestion();
                        question.CreateQuestion();
                        question.CreateAnswers();
                        question.CreateRightAnswer();
                        questions.Add(question);
                        practicalExam.Questions = questions;

                    }
                }
            }
            else
                Console.WriteLine("Invalid input for the number of questions.");
        }
    }
}
