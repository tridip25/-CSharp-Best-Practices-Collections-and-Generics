using System;

namespace StudentGradeCalculateProject
{
    public class DisplayDetails
    {
        public void displayStudentDetails()
        {
            var getStudent = new AddGetNewStudent();
            var studentList = getStudent.getStudent();

            if(studentList.Count == 0)
            {
                Console.WriteLine("No data found!!!!!!!!");
            }
            foreach(var student in studentList)
            {
                Console.WriteLine("Student id: "+student.StudentId + "    Student Name: " +student.Name+ "    Branch: " + student.Branch + "   Semester: " + student.Semester + "   GRADE(CGPA): " + student.Cgpa);
            }
        }
    }
}