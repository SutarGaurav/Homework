using System;
using System.Collections.Generic;
using System.Text;
//Collections List
namespace CSHomework.May022022
{
    class Student
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal float Per { get; set; }
        public override string ToString()
        {
            return $"{Id} {Name} {Per}";
        }
    }
    class StudentMain
    {
        static void Main(string[] args)
        {
            List<Student> studentlist = new List<Student>()
            {
                new Student{ Id = 101, Name= "A", Per = 90.5F},
                new Student{ Id = 102, Name = "B", Per = 95.5F},
                new Student{ Id = 103, Name = "C", Per = 94.2F}
            };
            foreach(Student s in studentlist)
            {
                Console.WriteLine(s);
            }
        }
    }
}
