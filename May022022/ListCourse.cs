using System;
using System.Collections.Generic;
using System.Text;
//Collections List
namespace CSHomework.May022022
{
    class Course
    {
        internal byte StudNos { get; set; }
        internal string CourseName { get; set; }
        internal byte Batch { get; set; }
        public override string ToString()
        {
            return $"{StudNos} \t{CourseName} \t{Batch}";
        }
    }
    class CourseMain
    {
        static void Main(string[] args)
        {
            List<Course> courselist = new List<Course>();
            Course c1 = new Course();
            c1.StudNos = 25;
            c1.CourseName = "C#";
            c1.Batch = 101;
            Course c2 = new Course();
            c2.StudNos = 20;
            c2.CourseName = "Java";
            c2.Batch = 102;
            Course c3 = new Course();
            c3.StudNos = 30;
            c3.CourseName = "JS";
            c3.Batch = 103;
            courselist.Add(c1);
            courselist.Add(c2);
            courselist.Add(c3);
            foreach(Course c in courselist)
            {
                Console.WriteLine(c);
            }
            
        }
    }
}
