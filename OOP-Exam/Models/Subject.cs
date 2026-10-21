using OOP_Exam.Exams;
using OOP_Exam.Questions;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam.Models
{
    public enum ExamType
    {
        Practical = 1,
        Final = 2
    }
    public class Subject
    {
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; private set; }


        public void CreateExam( ExamType examType, int time, Question[] questions)
        {
            switch (examType)
            {
                case ExamType.Practical:
                    Exam = new PracticalExam(time, questions);
                    break;

                case ExamType.Final:
                    Exam = new FinalExam(time, questions);
                    break;

                default:
                    throw new ArgumentException("Invalid exam type.");
            }
        }

        public override string ToString()
        {
            return $"Subject ID: {SubjectId}, Subject Name: {SubjectName}";
        }
    }
}
