using System;
using System.Collections.Generic;

namespace StudentGradeCalculateProject
{
    public class Grade
    {
        AddGetNewStudent getStudentList =new AddGetNewStudent();

       // IList<Student> list = getStudentList.getStudent();



        public void checkGradeById(string id)
        {
            // AddGetNewStudent getStudentList =new AddGetNewStudent();
         int flag = 0;
         var list = getStudentList.getStudent();
            foreach(var student in list)
            {
                if(id == student.StudentId)
                {
                    Console.WriteLine("CGPA(Grade) IS: "+student.Cgpa);
                    flag = 99;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine("Id not found");
            }
        }

        public void setGradeById(string studentid)
        {
            int flag = 0;
            var list = getStudentList.getStudent();
            Console.WriteLine("Total items :"+list.Count);
               foreach(var student in list)
            {

                if(studentid == student.StudentId)
                {
                    Console.WriteLine("Enter the grade: ");
                    var input = Console.ReadLine();
                    student.Cgpa = double.Parse(input);
                    flag = 99;
                }
            }
             if(flag == 0)
            {
                Console.WriteLine("Id not found");
            }

        }

       
    }
}