using OOP_Exam.Models;
using OOP_Exam.Questions;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam.Exams
{
    public class FinalExam : Exam
    {
        public FinalExam(int time, Question[] questions) : base(time, questions)
        {
        }

        public override void ShowExam()
        {
            Answer[] studentAnswers = new Answer[NumberOfQuestions];

            int grade = 0;
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.WriteLine($"Question {i + 1}: {Questions[i].Body}");
                Questions[i].DisplayQuestion();
                int answerId;
                while (true)
                {
                    Console.Write("Enter your answer ID: ");

                    if (int.TryParse(Console.ReadLine(), out answerId)
                        && Questions[i].Answers.Any(a => a.AnswerId == answerId))
                    {
                        break;
                    }

                    Console.WriteLine("Invalid answer ID. Try again.");
                }
                studentAnswers[i] = Questions[i].Answers.First(a => a.AnswerId == answerId);

                Console.WriteLine();
            }
            Console.Clear();
            Console.WriteLine("Final Exam Results:");
            Console.WriteLine();
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Question question = Questions[i];
                Console.WriteLine($"Question {i + 1}: {question.Body}");
                Console.WriteLine($"Your Answer => {studentAnswers[i].AnswerText}");
                Console.WriteLine($"Correct Answer => {question.RightAnswer.AnswerText}");

                if (studentAnswers[i].AnswerId == question.RightAnswer.AnswerId)
                {
                    grade += question.Mark;
                }
                Console.WriteLine();
            }
            int totalMarks = Questions.Sum(q => q.Mark);

            Console.WriteLine($"Your Grade is {grade} from {totalMarks}");
            Console.WriteLine("Thank you");
        }
    }
}
