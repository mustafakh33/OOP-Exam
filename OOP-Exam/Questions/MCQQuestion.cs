using OOP_Exam.Models;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace OOP_Exam.Questions
{
    public class MCQQuestion : Question
    {
        public MCQQuestion(string body, int mark, Answer[] answers, Answer rightAnswer): base("MCQ Question", body, mark, answers, rightAnswer)
        {
        }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Header}:    Mark {Mark}");

            foreach (Answer answer in Answers)
            {
                Console.WriteLine(answer);
            }
        }
    }
}
