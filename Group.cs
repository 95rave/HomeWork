using StudentAndGroupClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndGroupClass.Models
{
    public class Group
    {
        public int No { get; set; }
        public int Limit { get; set; }
        public Student[] Students { get; private set; }

        public Group(int no, int limit)
        {
            No = no;
            Limit = limit;
            Students = new Student[Limit];
        }

        public void AddStudent(Student student)
        {
            if (Students.Count(s => s != null) < Limit)
            {
                Student[] newStudents = new Student[Students.Length + 1];
                for (int i = 0; i < Students.Length; i++)
                {
                    newStudents[i] = Students[i];
                }
                newStudents[newStudents.Length - 1] = student;
                Students = newStudents;
            }
            else
            {
                Console.WriteLine("Grup doludur.");
            }
        }

        public Student[] GetStudents()
        {
            return Students;
        }
    }

}

