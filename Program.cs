using StudentAndGroupClass.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        Group group = new Group(137,3);

        Student student1 = new Student("eli", "eliyev");
        group.AddStudent(student1);

        Student student2 = new Student("veli", "veliyev");
        group.AddStudent(student2);

        Student student3 = new Student("pirveli", "piriyev");
        group.AddStudent(student3);

        Student student4 = new Student("gultac", "nebilime");
        group.AddStudent(student4);

        Student[] students = group.GetStudents();
        foreach (Student student in students)
        {
            if (student != null)
            {
                Console.WriteLine("Name: {0} {1}", student.Name, student.Surname);
            }
        }

    }
}
