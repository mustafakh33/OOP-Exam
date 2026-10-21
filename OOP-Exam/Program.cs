using OOP_Exam.Exams;
using OOP_Exam.Models;
using OOP_Exam.Questions;

namespace OOP_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Answer[] mcqAnswers =
            {
    new Answer(1, "IComparable"),
    new Answer(2, "IEnumerable"),
    new Answer(3, "ICloneable"),
    new Answer(4, "IDisposable")
};

            Question q1 = new MCQQuestion(
                "Which Interface allows an object to create a copy of itself?",
                10,
                mcqAnswers,
                mcqAnswers[2]
            );

            Question q2 = new TrueFalseQuestion(
                "C# is an object-oriented programming language.",
                10,
                new Answer(1, "True")
            );

            Question[] questions = { q1, q2 };

            // Create Subject
            Subject subject = new Subject(1, "C# Programming");

            Console.WriteLine(subject);

            // Create Exam through Subject
            subject.CreateExam(ExamType.Final, 40, questions);

            // Start the exam
            subject.Exam.ShowExam();


        }
    }
}
