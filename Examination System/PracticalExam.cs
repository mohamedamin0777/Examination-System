using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class PracticalExam : Exam
    {
        public override void CheckAnswers()
        {
            Console.WriteLine("Answer Model: ");

            foreach (var question in Questions)
            {
                if (question.CorrectAnswer.AnswerId == enteredAnswerID)
                {
                    GainedMark += question.Mark;
                    Console.WriteLine($"{Questions.IndexOf(question) + 1}.  the answer {enteredAnswerID} is Correct!");
                }
                else
                    Console.WriteLine($"{Questions.IndexOf(question) + 1}.  Incorrect. the correct answer is: {question.CorrectAnswer.AnswerText}");
               
                Console.WriteLine();
            }
        }
    }
}
