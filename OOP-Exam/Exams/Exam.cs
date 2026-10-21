using OOP_Exam.Questions;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam.Exams
{
    public abstract class Exam
    {
        public int Time { get; set; }

        public int NumberOfQuestions
        {
            get { return Questions.Length; }
        }

        public Question[] Questions { get; set; }

        protected Exam(int time, Question[] questions)
        {
            Time = time;
            Questions = questions;
        }

        public abstract void ShowExam();
    }
}
