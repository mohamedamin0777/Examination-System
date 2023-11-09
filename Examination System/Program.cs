using System.Diagnostics;

namespace Examination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject mathSubject = new Subject
            {
                SubjectId = 1,
                SubjectName = "Math"
            };

            mathSubject.CreateExam();
            Console.Clear();
            Console.WriteLine("Do you want to start the exam(y | n): ");
            
            if(char.Parse(Console.ReadLine()) == 'y')
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                mathSubject.ExamOfSubject.ShowExamForm();
                mathSubject.ExamOfSubject.CheckAnswers();
                mathSubject.ExamOfSubject.PrintResult();
                Console.WriteLine($"the elapsed time = {sw.Elapsed}");
            }
        }
    }
}