using OOP_Exam.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam.Questions
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string body, int mark, Answer rightAnswer): base("True/False Question",body, mark, new Answer[]
           {
                    new Answer(1, "True"),
                    new Answer(2, "False")
           },
           rightAnswer)
        {
        }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Header}:    Mark {Mark}");
            Console.WriteLine($"True/False Question: {Body}");

            foreach (Answer answer in Answers)
            {
                Console.WriteLine(answer);
            }
        }
    }
}
