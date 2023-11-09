using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class TrueFalseQuestion : Question
    {
        public override void CreateAnswers()
        {
            string[] answerText = { "Yes", "No" };
            for (int j = 0; j < answerText.Length; j++)
            {
                Answers.Add(new Answer
                {
                    AnswerId = j + 1,
                    AnswerText = answerText[j]
                });
            }
        }
    }
}
