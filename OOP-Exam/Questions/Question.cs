using OOP_Exam.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam.Questions
{
    public abstract class Question
    {
        protected Question(string header, string body, int mark, Answer[] answers, Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = answers;
            RightAnswer = rightAnswer;
        }

        public string Header { get; set; }

        public string Body { get; set; }

        public int Mark { get; set; }

        public Answer[] Answers { get; set; }

        public Answer RightAnswer { get; set; }

        public abstract void DisplayQuestion();

        public override string ToString()
        {
            return $"{Header}: {Body}";
        }
    }
}
