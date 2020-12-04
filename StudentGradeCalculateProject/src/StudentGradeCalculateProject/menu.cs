using System;

namespace StudentGradeCalculateProject
{
    public class menu
    {
        AddGetNewStudent addOrGetStudent = new AddGetNewStudent();
        DisplayDetails details = new DisplayDetails();

        Grade grade = new Grade();
        public void getMenu()
        {
            while(true)
            {
                Console.WriteLine("*************---SELECT YOUR CHOICE---*************");
                Console.WriteLine("**************  1/ Add New Student   *************");
                Console.WriteLine("**************  2/   Check Grade     *************");
                Console.WriteLine("**************  3/ Enter Grade(CGPA) *************");
                Console.WriteLine("**************  4/ Display Details   *************");
                Console.WriteLine("**************----ENTER 99 TO EXIT---*************");
                
                try{
                var input = Console.ReadLine();
                
                var choice = int.Parse(input);
                
                
                switch(choice)
                {
                    case 1:
                       addOrGetStudent.addStudent();
                    break;

                    case 2:
                        Console.WriteLine("Enter the Student ID you would like to CHECK the grade for:");
                        var id = Console.ReadLine();
                        grade.checkGradeById(id);
                    break;

                    case 3:
                        Console.WriteLine("Enter the Student ID you would like to SET the grade for:");
                        var Studentid = Console.ReadLine();
                        grade.setGradeById(Studentid);
                    break;
                    
                    case 4:
                        details.displayStudentDetails();                       
                    break;

                    case 99:
                        return;
                
                    default:
                        Console.WriteLine("Invalid choice");
                    break;
                }

            }               

            catch(Exception e)
                {
                    Exception p = e;  //just to get rid of the warning
                    Console.WriteLine("Invalid input");
                }       

            }
        }
    }
}