using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class FinalExam : Exam
    {
        public override void CheckAnswers()
        {
            foreach (var question in Questions)
            { 
                if (enteredAnswerID == question.CorrectAnswer.AnswerId)
                    GainedMark += question.Mark;
                Console.WriteLine();
            }
        }
    }
}
