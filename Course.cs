using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    internal class Course
    {
        public int StudentId { get; set; }
        public string CourseName { get; set; }

        public Course(int studentId, string courseName)
        {
            StudentId = studentId;
            CourseName = courseName;
        }

        public override string ToString()
        {
            return $"Course: {CourseName} (Student ID: {StudentId})";
        }
    }
}
