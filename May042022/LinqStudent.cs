using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Assignments.May042022
{
    class Student
    {
        internal byte RollNo { get; set; }
        internal string SName { get; set; }
        internal float Perc { get; set; }
        internal string Branch { get; set; }
    }
    class StudentMain
    {
        static void Main(string[] args)
        {
            List<Student> stdlist = new List<Student>()
            {
                new Student {RollNo = 01, SName = "Anvi", Perc = 94.5F, Branch = "Performance Arts"},
                new Student {RollNo = 02, SName = "Gaurav", Perc = 89.40F, Branch = "Computer"},
                new Student {RollNo = 03, SName = "Preana", Perc = 95.1F, Branch = "IT"},
                new Student {RollNo = 04, SName = "Roshan", Perc = 90.68F, Branch = "Design"}
            };
            //1 Percentage wise high to low
            Console.WriteLine("Percentage wise high to low");
            var result1 = from s in stdlist
                          orderby s.Perc descending
                          select s;
            foreach(Student s in result1)
            {
                Console.WriteLine($"\t{s.RollNo} \t{s.SName} \t{s.Perc} \t{s.Branch}");
            }
            /*_____________________________________________________________________________________*/
            //2 Name starting with specific character
            Console.WriteLine("\nName starting with specific character");
            var result2 = from s in stdlist
                          where s.SName.StartsWith('A')
                          select s;
            foreach (Student s in result2)
            {
                Console.WriteLine($"\t{s.RollNo} \t{s.SName} \t{s.Perc} \t{s.Branch}");
            }
            /*_____________________________________________________________________________________*/
            //3 From specific branch
            Console.WriteLine("\nFrom specific branch");
            var result3 = from s in stdlist
                          where s.Branch.Contains("Performance Arts")
                          select s;
            foreach (Student s in result3)
            {
                Console.WriteLine($"\t{s.RollNo} \t{s.SName} \t{s.Perc} \t{s.Branch}");
            }
            /*_____________________________________________________________________________________*/
            //4 Above certain percentage
            Console.WriteLine("\nAbove certain percentage");
            var result4 = from s in stdlist
                          where s.Perc > 90
                          select s;
            foreach (Student s in result4)
            {
                Console.WriteLine($"\t{s.RollNo} \t{s.SName} \t{s.Perc} \t{s.Branch}");
            }
            /*_____________________________________________________________________________________*/
            //5 Student from specific branch, having specific percentage
            Console.WriteLine("\nStudent from specific branch, having specific percentage");
            var result5 = from s in stdlist
                          where s.Perc > 90 && s.Branch.Contains("IT")
                          select s;
            foreach (Student s in result5)
            {
                Console.WriteLine($"\t{s.RollNo} \t{s.SName} \t{s.Perc} \t{s.Branch}");
            }
            /*_____________________________________________________________________________________*/
            //6 Students in Aplhabet order
            Console.WriteLine("\nStudents in Aplhabet order");
            var result6 = from s in stdlist
                          orderby s.SName
                          select s;
            foreach (Student s in result6)
            {
                Console.WriteLine($"\t{s.RollNo} \t{s.SName} \t{s.Perc} \t{s.Branch}");
            }
            /*_____________________________________________________________________________________*/
        }
    }
}
