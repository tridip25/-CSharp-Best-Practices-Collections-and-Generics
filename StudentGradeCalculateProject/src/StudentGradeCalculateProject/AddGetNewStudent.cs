using System;
using System.Collections.Generic;

namespace StudentGradeCalculateProject
{
    public class AddGetNewStudent
    {
        public static List<Student> studentList = new List<Student>();
        public void addStudent()
        {
            var student = new Student();

                student.Cgpa = 0.0;

                 Console.WriteLine("Enter id ");
                 student.StudentId = Console.ReadLine();
                        
                 Console.WriteLine("Enter name ");
                 student.Name = Console.ReadLine();
                        
                 Console.WriteLine("Enter branch ");
                 student.Branch = Console.ReadLine();

                 Console.WriteLine("Enter semester ");
                 student.Semester = Console.ReadLine();

            studentList.Add(new Student(){StudentId = student.StudentId, Name = student.Name ,
             Branch = student.Branch ,Semester=student.Semester});


         }

        public IList<Student> getStudent()
        {
                return studentList;
        }
    }
}