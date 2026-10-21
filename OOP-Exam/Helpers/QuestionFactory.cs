using OOP_Exam.Models;
using OOP_Exam.Questions;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam.Helpers
{
    public class QuestionFactory
    {
        public static Question CreateQuestion(ExamType examType, int questionNumber)
        {
            Console.WriteLine();
            Console.WriteLine($"Enter details for question {questionNumber}:");

            int questionType = 1;

            if (examType == ExamType.Final)
            {
                questionType = ConsoleInput.ReadInt("Choose question type: 1 for MCQ, 2 for True/False: ", 1, 2 );
            }

            string body = ConsoleInput.ReadText("Please enter the question body: ");

            int mark = ConsoleInput.ReadInt("Please enter the question mark: ", 1, 100);

            if (questionType == 1)
            {
                Answer[] answers = new Answer[4];

                Console.WriteLine("Choices of Question:");

                for (int i = 0; i < answers.Length; i++)
                {
                    string answerText = ConsoleInput.ReadText($"Please enter choice number {i + 1}: " );

                    answers[i] = new Answer(i + 1, answerText);
                }

                int correctId = ConsoleInput.ReadInt( $"Please enter the ID of the correct answer (1 to {answers.Length}): ", 1, answers.Length );

                return new MCQQuestion(body, mark, answers, answers[correctId - 1] );
            }
            else
            {
                int correctId = ConsoleInput.ReadInt("Please enter the ID of the correct answer (1 for True, 2 for False): ",1, 2);

                return new TrueFalseQuestion( body, mark, new Answer(correctId, correctId == 1 ? "True" : "False"));
            }
        }
    }
}
