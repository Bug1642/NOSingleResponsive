using System;
namespace SingleResponsibility
{
    public class Student
    {
        public string StudentName { get; set; }
        public string StudentSurName { get; set; }
        public int StudentNo { get; set; }

        public Student(string name, string surName, int no)
        {
            this.StudentName = name;
            this.StudentSurName = surName;
            this.StudentNo = no;
        }
        public void WriteStudent()
        {
            Console.WriteLine("Student Name: " + this.StudentName);
            Console.WriteLine("Student Surname: " + this.StudentSurName);
            Console.WriteLine("Student Number: " + this.StudentNo);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Jack", "Necker", 18);
            student.WriteStudent();
        }
    }
}
