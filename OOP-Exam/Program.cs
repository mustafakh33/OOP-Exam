using OOP_Exam.Exams;
using OOP_Exam.Helpers;
using OOP_Exam.Models;
using OOP_Exam.Questions;
using System.Diagnostics;

namespace OOP_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Enter the type of exam (1 for Practical, 2 for Final):");

            int examTypeValue = ConsoleInput.ReadInt("", 1, 2);

            ExamType examType = (ExamType)examTypeValue;

            int time = ConsoleInput.ReadInt("Please enter the time for the exam (30 to 180 minutes): ", 30, 180 );

            int numberOfQuestions = ConsoleInput.ReadInt("Please enter the number of questions: ", 1, 50 );

            Console.Clear();

            Question[] questions = new Question[numberOfQuestions];

            for (int i = 0; i < numberOfQuestions; i++)
            {
                questions[i] = QuestionFactory.CreateQuestion( examType, i + 1);
            }
            Console.Clear();

            Subject subject = new Subject( 1, "C# Programming" );

            subject.CreateExam( examType, time, questions );

            string startExam;

            do
            {
                startExam = ConsoleInput.ReadText( "Do You Want To Start Exam (Y | N): ").ToUpper();

                if (startExam != "Y" && startExam != "N")
                {
                    Console.WriteLine("Please enter Y or N.");
                }
            }
            while (startExam != "Y" && startExam != "N");

            if (startExam == "N")
            {
                Console.WriteLine("Exam cancelled.");
                return;
            }

            Console.WriteLine();
            Console.Clear();

            Stopwatch stopwatch = Stopwatch.StartNew();

            subject.Exam.ShowExam();

            stopwatch.Stop();

            Console.WriteLine($"Time = {stopwatch.Elapsed}");
        }
    }
}