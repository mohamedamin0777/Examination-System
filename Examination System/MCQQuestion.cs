using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class MCQQuestion : Question
    {
        public override void CreateAnswers()
        {
            Console.WriteLine("Enter the number of answers:");
            int numberOfAnswers = int.Parse(Console.ReadLine());
            
            for (int j = 0; j < numberOfAnswers; j++)
            {
                Console.WriteLine($"Enter answer {j + 1} text:");
                string answerText = Console.ReadLine();

                Answers.Add(new Answer
                {
                    AnswerId = j + 1,
                    AnswerText = answerText
                });
            }
        }
    }
}
